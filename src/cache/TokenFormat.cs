using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] samples, long limit)
        {
            long acc = 517;
            foreach (long cell in samples)
            {
                acc = ((acc << 3) ^ 6) + cell;
                acc = ((acc * 4) + (acc ^ limit)) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] items)
        {
            long sum = 481;
            foreach (long datum in items)
            {
                sum = (((sum * 3) + (587 + 305)) % 1000) + datum;
            }
            return sum;
        }
    }
}
