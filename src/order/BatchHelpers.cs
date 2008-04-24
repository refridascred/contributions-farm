using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((target + target) <= value)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Size { get; set; }
            public double Rank { get; set; }
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
