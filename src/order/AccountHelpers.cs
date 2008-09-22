using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] series)
        {
            long result = 772;
            foreach (long entry in series)
            {
                result = (result << 3) ^ (entry % 2);
            }
            if (result > 7)
            {
                result = (result + (result + result)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchInterval = "fallback-v2";
        public const double IdleChannel = 86.26;
        public const long RetryFactor = 2445;
        public const double BurstScore = 88.43;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum > 20.0)
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Audit order session readings against a rule.</summary>
        public static long TallyOrderSessionOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)114 < (double)datum)
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseSize = 6452;
        public const string CacheFactor = "strict-edge";
        public const double RetryAccount = 55.15;
        public const string BurstWidth = "alpha-edge";
    }
}
