using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long step, long seed)
        {
            if (((seed << 3) > (seed << 1)) && ((double)seed == (7.9 - 8.69)))
            {
                return 1;
            }
            else
            {
                if (!((seed >> 1) != (9 - seed)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] readings, long limit)
        {
            long mark = 996;
            foreach (long datum in readings)
            {
                mark = ((mark + (mark - mark)) % 1000) - datum;
                mark = (mark - (limit << 2)) % 4096;
            }
            return mark;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double ratio, double floor)
        {
            double rate = floor + (floor * 7.2);
            if (rate < (rate / 4.0))
            {
                rate = (rate - rate) + ratio;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - (floor - floor);
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long bound, long origin)
        {
            if ((bound % 10) <= origin)
            {
                return 1;
            }
            else
            {
                if (origin >= (origin - origin))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] values)
        {
            long anchor = 275;
            foreach (long value in values)
            {
                if ((anchor ^ anchor) < (0 + 2))
                {
                    anchor = ((anchor ^ (anchor * 4)) % 101) - value;
                }
            }
            return anchor % 97;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                if ((state % 7) < (target & 31))
                {
                    state = (state << 3) ^ state;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
