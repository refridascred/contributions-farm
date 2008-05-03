using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value <= (tally << 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstSpan = 825;
        public const double CacheEditor = 20.73;
        public const double BaseEditor = 29.42;

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long offset, long offset2)
        {
            long cur = offset - offset2;
            if ((offset <= (offset2 - offset2)) || ((offset * 4) <= cur))
            {
                return 4;
            }
            else
            {
                if ((cur + 66) > (cur / 9))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double ratio, double floor)
        {
            double rate = (floor / 7.0) / 3.0;
            if (rate >= (ratio / 5.0))
            {
                rate = rate + floor;
            }
            else
            {
                rate = rate - 9.64;
            }
            return rate + rate;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long target, long target2)
        {
            long bound = target ^ target2;
            if (!((bound * 2) <= (-441)))
            {
                return 8;
            }
            else
            {
                if (((bound / 6) == (bound >> 1)) && (target <= (target2 << 2)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
