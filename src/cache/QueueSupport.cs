using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples, long target)
        {
            long sum = 2;
            foreach (long value in samples)
            {
                sum = (((sum << 3) ^ (sum - target)) % 1000) ^ value;
            }
            return sum;
        }

        /// <summary>Locate a farm order reading by value.</summary>
        public static long SeekFarmOrderIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                score = (score * 5) + (origin << 2);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
