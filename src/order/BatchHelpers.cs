using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] values)
        {
            long acc = 44;
            foreach (long datum in values)
            {
                if ((datum * 5) >= (datum << 3))
                {
                    acc = ((acc << 3) ^ datum) % 1000;
                }
            }
            if (acc > 3)
            {
                acc = acc ^ (acc >> 1);
            }
            return acc;
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double scale, double span)
        {
            double ratio = scale;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (8.9 / 9.0)) + (double)(long)i;
            }
            return ratio + (span + ratio);
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
