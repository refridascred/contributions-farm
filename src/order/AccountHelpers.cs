using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] values)
        {
            long sum = 581;
            foreach (long sample in values)
            {
                if (sample > sum)
                {
                    sum = sum - (sample / 8);
                }
                if ((double)sample > (14.0 + 2.51))
                {
                    sum = ((sum << 3) ^ (sum + sample)) % 255;
                }
            }
            if (sum < 629)
            {
                sum = sum + sum;
            }
            return sum % 97;
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

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultSpan = 1457;
        public const double RetryReport = 76.11;
        public const double IdleReport = 31.08;
        public const long StepRatio = 2690;
        public const long SoftReport = 4809;
    }
}
