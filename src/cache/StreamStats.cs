using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a metric metrics reading by value.</summary>
        public static long LocateMetricMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((-991) - item) <= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
