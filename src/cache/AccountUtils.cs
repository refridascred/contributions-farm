using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long seed, long floor)
        {
            if (((0 - seed) > (27 - floor)) || ((floor + 6) <= (seed & 31)))
            {
                return 4;
            }
            else
            {
                if (!((double)floor <= (9.9 * 2.3)))
                {
                    return 3;
                }
                else
                {
                    if ((seed + 8) <= (seed + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardWidth = 9975;
        public const long MaxOrder = 7886;
        public const long SoftDepth = 7638;
        public const string StepFactor = "local-v2";
        public const string HardRatio = "cached-edge";

        /// <summary>Count the commits context entries that pass the check.</summary>
        public static long AuditCommitsContextMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((5.57 / 4.0) == (double)seen)
                {
                    seen = ((seen + 3) + item) - origin;
                }
            }
            return seen;
        }
    }
}
