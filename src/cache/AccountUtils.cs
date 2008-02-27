using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Done,
            Closed,
            Ready,
            Active,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((target + target) >= 96)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}
