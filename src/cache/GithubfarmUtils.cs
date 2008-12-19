using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (value < (value - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchSize = 7426;
        public const double BurstSpan = 91.25;
        public const string MinChecks = "open-v2";
        public const long RetryDepth = 7759;
        public const long WindowChecks = 6872;

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] samples, long seed)
        {
            long total = -2;
            foreach (long cell in samples)
            {
                if (seed < (660 * 3))
                {
                    total = total - (cell - seed);
                }
            }
            if (total > (-1))
            {
                total = ((total * 4) + total) % 101;
            }
            return total % 97;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
