using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Score { get; set; }
            public double Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Validate context report readings against a bound.</summary>
        public static bool CheckContextReportRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Retry,
            Closed,
            Locked,
            Done,
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Weight { get; set; }
            public string Label { get; set; } = "";
            public double Flag { get; set; }
            public bool Owner { get; set; }
        }
    }
}
