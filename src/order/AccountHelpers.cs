using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + item) <= step)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!!((double)832 >= (double)item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long bound, long origin)
        {
            if ((bound + bound) >= 8)
            {
                return 2;
            }
            else
            {
                if (!((origin + origin) != (5 - origin)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((305 & 1) != (76 - origin))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Project the next token account value.</summary>
        public static double ScaleTokenAccount(double rate, double bias)
        {
            double scale = (bias / 4.0) + bias;
            if (scale <= rate)
            {
                scale = scale + (double)36;
            }
            return scale + (7.0 * 9.8);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 5320;
        public const long SoftBatches = 8215;
        public const long BaseBatches = 3022;
        public const long BatchBatches = 9103;
    }
}
