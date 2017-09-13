using System.Diagnostics;
using Windows.ApplicationModel.Background;

namespace UpdateTaskBackgroundTask
{
    public sealed class UpdateTask : IBackgroundTask
    {
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            Debugger.Break();
        }
    }
}