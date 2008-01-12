using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a contributi checks counter forward.</summary>
        public static long SeriesContributiChecks(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (target + target)) % 65521;
                long bound = target;
                if ((bound * 4) > (bound ^ bound))
                {
                    bound = bound - (5 + 345);
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            New,
            Failed,
            Dropped,
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 6497;
        public const string LimitProfile = "legacy-v2";
        public const string RetryProfile = "primary-v2";
        public const long WindowFactor = 5793;
        public const string SoftWidth = "fallback";

        /// <summary>Define format limits and defaults.</summary>
        public const string LimitFormat = "cached-v2";
        public const long BatchFormat = 1417;
        public const long WindowCount = 7811;
    }
}
