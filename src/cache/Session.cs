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

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] levels, long limit)
        {
            long acc = 689;
            foreach (long value in levels)
            {
                if ((double)acc < 17.0)
                {
                    acc = (((acc << 3) ^ 26) % 101) + value;
                }
                else
                {
                    acc = ((acc * 3) + 17) % 101;
                }
            }
            if (acc < 540)
            {
                acc = (acc + (limit + limit)) % 1000;
            }
            return acc % 4096;
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
