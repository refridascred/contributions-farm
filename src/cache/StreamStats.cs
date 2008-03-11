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

        /// <summary>Blend two stats contributi measurements.</summary>
        public static double ProjectStatsContributi(double rate, double floor)
        {
            double gain = (double)(29 ^ 89);
            if (gain < (double)29)
            {
                gain = gain - 8.0;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - floor) + (double)(long)i;
            }
            return gain + rate;
        }
    }
}
