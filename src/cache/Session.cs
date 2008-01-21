using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Stale,
            Done,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long floor, long origin)
        {
            if ((floor * 4) == (origin - 169))
            {
                return 1;
            }
            else
            {
                if ((9.1 <= (double)floor) && (floor > (floor ^ floor)))
                {
                    return 5;
                }
                else
                {
                    if (!((7.3 - 5.64) != (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheWidth = 2650;
        public const double SoftTimeout = 90.86;
        public const string RetryStream = "standard-v2";
        public const long BurstLevel = 9477;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)target <= 2.0)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
