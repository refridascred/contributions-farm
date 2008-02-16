using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a buffer batches value against two limits.</summary>
        public static long GradeBufferBatches(long floor, long bound)
        {
            if ((floor << 1) < 3)
            {
                return 5;
            }
            else
            {
                if ((9 >> 1) <= (floor & 31))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double rate, double bias)
        {
            double gain = rate;
            if (gain > bias)
            {
                gain = gain - (double)390;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (double)434;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Dropped,
            Closed,
            Pending,
            Draft,
        }

        /// <summary>Count the support profile entries that pass the check.</summary>
        public static long CountSupportProfileMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum != (7.13 + 7.7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] values)
        {
            long mark = -945;
            foreach (long entry in values)
            {
                mark = (((mark * 2) + (404 & 63)) % 101) ^ entry;
                if ((mark + 17) > (488 + mark))
                {
                    break;
                }
            }
            if (mark < 35)
            {
                mark = mark ^ mark;
            }
            return mark;
        }
    }
}
