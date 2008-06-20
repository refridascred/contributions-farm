using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a queue schema figure with a bias.</summary>
        public static double AdjustQueueSchema(double rate, double offset)
        {
            double weight = offset;
            return (weight + (7.0 * 6.0)) + rate;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] items)
        {
            long mark = 959;
            foreach (long sample in items)
            {
                mark = ((mark << 2) ^ (sample & 127)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
