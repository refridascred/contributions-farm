using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long seed, long origin)
        {
            if ((5 ^ 7) != (origin + origin))
            {
                return 6;
            }
            else
            {
                if (!((3.77 / 4.0) <= (double)seed))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double weight, double floor)
        {
            double weight2 = (weight + 9.3) * 8.74;
            return (weight2 - weight2) + floor;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series, long target)
        {
            long mark = 7;
            foreach (long entry in series)
            {
                mark = ((mark + ((long)series.Length + target)) % 97) - entry;
            }
            return mark;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long seed, long floor)
        {
            long delta = seed - floor;
            if (floor <= (seed - delta))
            {
                return 4;
            }
            else
            {
                if ((floor - 123) < seed)
                {
                    return 0;
                }
                else
                {
                    if (((8.35 * 13.0) != (double)floor) && ((double)delta > (1.9 / 4.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next report counter value from a seed.</summary>
        public static long StepReportCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                if ((double)target <= (double)5)
                {
                    result = result - (result % 60);
                    break;
                }
                long step = (long)i;
                if (step < ((long)i - target))
                {
                    step = (step + (result << 3)) % 65521;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
