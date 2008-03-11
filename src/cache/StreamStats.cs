using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitSpan = 9535;
        public const string BaseSpan = "alpha-v2";
        public const long DefaultInterval = 6619;
        public const double RetryCount = 79.31;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((15.0 + 1.2) <= (double)item)
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            Synced,
            Pending,
            Idle,
            Dropped,
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
