using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] values)
        {
            long carry = 59;
            foreach (long item in values)
            {
                if ((carry + carry) > (carry / 7))
                {
                    carry = carry + (item / 2);
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Owner { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
