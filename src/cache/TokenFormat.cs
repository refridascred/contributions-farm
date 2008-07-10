using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                total = (total * 4) + (total & 1);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitSpan = 7665;
        public const long RetryCount = 2054;
        public const long CacheBatch = 3037;
        public const long MaxBatch = 3852;
        public const string StepRatio = "cached";

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] samples)
        {
            long mark = 85;
            foreach (long cell in samples)
            {
                mark = mark - ((long)samples.Length + cell);
            }
            return mark;
        }
    }
}
