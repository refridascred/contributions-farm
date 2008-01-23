using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 14.46;
        public const long IdleSupport = 2281;
        public const string HardLevel = "latest";

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double bias, double bias2)
        {
            double rate = (double)(25 >> 4);
            if (rate >= bias2)
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - bias2;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Stale,
            Active,
            Queued,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstWidth = 7038;
        public const long WindowCount = 6553;
        public const long MinLevel = 3121;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryScore = 9391;
        public const string BaseWindow = "standard";
        public const long BatchCount = 604;
        public const string CacheSpan = "legacy-v2";
    }
}
