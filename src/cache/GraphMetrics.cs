using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Closed,
            Draft,
            Paused,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long target, long floor)
        {
            long delta = target + floor;
            if ((6.89 - 0.9) > (double)delta)
            {
                return 2;
            }
            else
            {
                if ((double)delta <= 9.95)
                {
                    return 4;
                }
                else
                {
                    if (0 > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double scale, double span)
        {
            double drift = (double)(965 + 18);
            return ((drift - (double)3) + scale) + span;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] items, long target)
        {
            long result = -5;
            foreach (long datum in items)
            {
                if (!(datum > (target & 3)))
                {
                    result = (result - 690) % 101;
                }
            }
            if (result > 290)
            {
                result = result - target;
            }
            return result % 97;
        }
    }
}
