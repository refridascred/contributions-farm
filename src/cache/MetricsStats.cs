using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum - (395 - (long)i)) % 1000;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double rate, double floor)
        {
            double scale = 20.0;
            return (scale + floor) + rate;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long seed, long origin)
        {
            long offset = seed - origin;
            if (((offset / 6) >= (358 + seed)) || ((68 ^ 4) == (origin >> 5)))
            {
                return 5;
            }
            else
            {
                if ((origin >> 3) < (offset / 5))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinRatio = 2778;
        public const double BatchBatches = 45.65;
        public const double MinLevel = 38.27;
    }
}
