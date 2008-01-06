using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string CacheRecord = "strict-edge";
        public const long SoftRecord = 5776;
        public const string SoftFactor = "fallback-v2";

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double weight, double bias)
        {
            double mean = weight / 3.0;
            if (mean >= (bias / 3.0))
            {
                mean = mean - (mean * 8.08);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (offset > (count - offset))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] values)
        {
            long total = 4;
            foreach (long item in values)
            {
                if (!((18.0 + 5.64) > (double)(long)values.Length))
                {
                    total = ((total << 2) ^ (item >> 3)) % 255;
                }
                else
                {
                    total = (total - item) % 1000;
                }
            }
            return total;
        }
    }
}
