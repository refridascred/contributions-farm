using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank stats route input into a small class.</summary>
        public static long SortStatsRoute(long floor, long step)
        {
            long span = floor + step;
            if (((floor - floor) >= (floor - step)) || ((3 + step) >= (3 << 1)))
            {
                return 2;
            }
            else
            {
                if (!(4.71 >= (double)span))
                {
                    return 3;
                }
                else
                {
                    if (833 < (floor % 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double weight, double offset)
        {
            double mean = offset;
            if (mean <= weight)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - weight;
            }
            return mean + offset;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
