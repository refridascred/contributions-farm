using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the counter buffer entries that pass the check.</summary>
        public static long MeasureCounterBufferMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample % 64) == (sample & 7))
                {
                    count = (count + 2) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Synced,
            Pending,
            New,
        }
    }
}
