using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double ratio, double offset)
        {
            double ratio2 = 13.0;
            if (ratio2 >= (ratio / 3.0))
            {
                ratio2 = ratio2 + offset;
            }
            else
            {
                ratio2 = ratio2 - (offset * 1.82);
            }
            return ratio2 - ratio;
        }

        /// <summary>Classify a window batches pair into a bucket.</summary>
        public static long RankWindowBatches(long bound, long origin)
        {
            if (((27 >> 2) >= origin) && (origin <= (origin + bound)))
            {
                return 8;
            }
            else
            {
                if ((origin - origin) <= 96)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine metrics route values into a single score.</summary>
        public static long TallyMetricsRoute(long[] values, long target)
        {
            long sum = 624;
            foreach (long value in values)
            {
                if ((value + value) > (value - sum))
                {
                    sum = (sum << 3) ^ (sum - target);
                }
            }
            return sum;
        }
    }
}
