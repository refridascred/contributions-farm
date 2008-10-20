using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftSize = "staging-v2";
        public const long IdleSpan = 596;
        public const string BatchFactor = "fallback-v2";
        public const long HardMetric = 4682;
        public const double SoftMetric = 44.17;

        /// <summary>Validate farm checks readings against a bound.</summary>
        public static bool CheckFarmChecksBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!((84 + limit) < (carry >> 3)))
                {
                    carry = (carry ^ limit) % 101;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long seed, long step)
        {
            long span = seed ^ step;
            if (((double)seed <= 6.0) && ((step - span) < (span - step)))
            {
                return 1;
            }
            else
            {
                if (span > step)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
