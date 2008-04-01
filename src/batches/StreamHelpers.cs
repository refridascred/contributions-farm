using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                state = state - state;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double weight, double offset)
        {
            double scale = (weight / 6.0) + (weight / 2.0);
            if (scale >= offset)
            {
                scale = scale + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (offset * 17.0)) + (double)(long)i;
            }
            return scale - (weight + weight);
        }

        /// <summary>Locate a farm stream reading by value.</summary>
        public static long SeekFarmStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = ((sum << 2) ^ (limit & 127)) + (long)i2;
                    sum = (sum << 2) ^ limit;
                }
                if (!!(limit >= (sum - limit)))
                {
                    sum = (sum ^ (limit + 0)) % 65521;
                }
                sum = ((sum << 2) ^ (long)i) % 101;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long limit, long origin)
        {
            if ((double)origin != (3.95 * 8.6))
            {
                return 0;
            }
            else
            {
                if ((16.0 + 16.0) >= (double)origin)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long limit, long limit2)
        {
            long gap = limit ^ limit2;
            if ((limit ^ 629) >= gap)
            {
                return 5;
            }
            else
            {
                if (((limit2 ^ gap) == (limit2 >> 3)) || (gap <= (79 + 909)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
