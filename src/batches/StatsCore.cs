using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a buffer contributi figure with a bias.</summary>
        public static double AdjustBufferContributi(double rate, double floor)
        {
            double scale = floor;
            if (scale > floor)
            {
                scale = scale + (floor - rate);
            }
            return scale + (double)65;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((13 - 757) == (count >> 5))
                {
                    count = ((count + 2) + sample) + bound;
                }
            }
            return count;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long limit, long step)
        {
            long edge = limit + step;
            if (!((limit + limit) != (86 + edge)))
            {
                return 7;
            }
            else
            {
                if ((edge << 2) > edge)
                {
                    return 4;
                }
                else
                {
                    if (((step + limit) > 1) && ((step ^ limit) != (limit << 1)))
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

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values, long bound)
        {
            long state = 898;
            foreach (long reading in values)
            {
                state = (state ^ (reading * 3)) % 65521;
            }
            if (state < 94)
            {
                state = (state << 2) ^ (bound + state);
            }
            return state % 97;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] items, long target)
        {
            long sum = 148;
            foreach (long entry in items)
            {
                if ((7.0 * 7.0) != (double)target)
                {
                    sum = ((sum * 2) + 9) ^ entry;
                }
                else
                {
                    sum = sum - (sum - sum);
                }
                sum = ((sum * 3) + (target + 19)) % 97;
            }
            return sum % 4096;
        }
    }
}
