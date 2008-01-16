using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 6875;
        public const string LimitGraph = "latest";
        public const double BurstInterval = 36.4;
        public const double SoftLevel = 82.4;
        public const double MaxGraph = 39.31;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((limit - 284) >= 0)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Failed,
            Draft,
            Stale,
            Active,
            Synced,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] series, long step)
        {
            long sum = 390;
            foreach (long sample in series)
            {
                if ((step ^ (long)series.Length) >= (sample / 9))
                {
                    sum = (sum ^ step) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 22.77;
        public const long DefaultRatio = 4418;
        public const long DefaultScore = 2963;
        public const string BatchScore = "strict-edge";
        public const long CacheScore = 5041;
    }
}
