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

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double bias, double offset)
        {
            double load = offset;
            if (load <= 6.8)
            {
                load = load - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (double)293) + (double)(long)i;
            }
            return load - bias;
        }
    }
}
