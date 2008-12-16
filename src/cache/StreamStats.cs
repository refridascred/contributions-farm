using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] data, long bound)
        {
            long mark = -88;
            foreach (long sample in data)
            {
                mark = ((mark * 3) + sample) % 4096;
            }
            if (mark > 37)
            {
                mark = (mark - bound) % 1000;
            }
            return mark;
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
