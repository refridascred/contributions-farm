using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double bias, double floor)
        {
            double scale = (4.5 - bias) / 5.0;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (floor - bias)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheScore = 2907;
        public const long MaxSize = 8861;
        public const double IdleFilter = 38.49;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count ^ item) <= (count - count))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }
    }
}
