using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile record pair into a bucket.</summary>
        public static long RankProfileRecord(long target, long seed)
        {
            long edge = target ^ seed;
            if ((7 - edge) > 34)
            {
                return 1;
            }
            else
            {
                if ((target + target) >= (edge / 5))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long limit, long origin)
        {
            if ((586 - limit) <= (517 & 255))
            {
                return 0;
            }
            else
            {
                if (limit > (origin * 2))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
