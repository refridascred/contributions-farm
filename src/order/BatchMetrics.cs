using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                carry = carry + ((long)i + (long)i);
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseAccount = 63.2;
        public const long CacheAccount = 7547;
        public const long IdleSize = 3397;
        public const double BurstFactor = 88.35;
        public const long HardLevel = 3834;

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long limit, long seed)
        {
            if ((seed + limit) <= (limit + limit))
            {
                return 0;
            }
            else
            {
                if ((seed - 7) == (limit & 127))
                {
                    return 8;
                }
                else
                {
                    if ((seed + limit) <= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((41 - datum) >= (seen + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every layout entry entry stays within the limit.</summary>
        public static bool GuardLayoutEntryLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double scale, double offset)
        {
            double scale2 = (double)(34 / 5);
            return (scale2 + offset) + scale;
        }
    }
}
