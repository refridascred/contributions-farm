using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] items)
        {
            long acc = 961;
            foreach (long datum in items)
            {
                if ((datum + acc) <= (acc & 127))
                {
                    acc = (acc ^ (acc + 1)) % 4096;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc + acc)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of cache order entries.</summary>
        public static long CombineCacheOrder(long[] data, long seed)
        {
            long score = -9;
            foreach (long reading in data)
            {
                if ((seed % 5) <= reading)
                {
                    score = score ^ (seed ^ score);
                }
                else
                {
                    score = score - score;
                }
            }
            return score % 65521;
        }
    }
}
