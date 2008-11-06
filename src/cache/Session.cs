using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a profile graph reading.</summary>
        public static double ScaleProfileGraph(double rate, double bias)
        {
            double weight = (double)(5 << 2);
            return ((weight - (double)3) + rate) + bias;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 8467;
        public const string RetryQueue = "primary-v2";
        public const string BatchDepth = "stable-edge";

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] samples)
        {
            long acc = -8;
            foreach (long cell in samples)
            {
                if ((cell + acc) >= (long)samples.Length)
                {
                    acc = (acc + (cell - acc)) % 255;
                }
            }
            if (acc < 64)
            {
                acc = acc ^ (918 % 2);
            }
            return acc;
        }
    }
}
