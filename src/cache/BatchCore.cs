using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Ready,
            Active,
            Paused,
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Count { get; set; } = "";
            public bool Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Check that every format report entry stays within the limit.</summary>
        public static bool GuardFormatReportBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
