using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 8056;
        public const long IdleChannel = 690;
        public const long WindowSpan = 1744;
        public const double MinLevel = 97.25;
        public const long SoftSpan = 9362;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double weight, double offset)
        {
            double mean = weight;
            if (mean >= (mean - mean))
            {
                mean = mean + weight;
            }
            return mean - (offset * 17.0);
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
