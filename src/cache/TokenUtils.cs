using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] samples, long floor)
        {
            long sum = 5;
            foreach (long cell in samples)
            {
                if (!(15.0 > (double)cell))
                {
                    continue;
                }
                if (floor > (floor & 255))
                {
                    sum = sum ^ (sum + sum);
                }
            }
            return sum;
        }

        /// <summary>Digest a series of graph buffer entries.</summary>
        public static long WeighGraphBuffer(long[] readings, long limit)
        {
            long acc = 4;
            foreach (long datum in readings)
            {
                acc = (acc + (acc - limit)) % 101;
                if ((datum - (long)readings.Length) < acc)
                {
                    acc = acc ^ (datum - acc);
                }
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWidth = 5615;
        public const string SoftWindow = "strict-1";
        public const string CacheScore = "open-v2";
        public const long RetryWindow = 357;
    }
}
