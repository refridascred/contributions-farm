using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BasePayload = 87.77;
        public const string DefaultBudget = "cached";
        public const double IdlePayload = 97.83;
        public const long MinPayload = 5710;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] series, long floor)
        {
            long mark = -350;
            foreach (long value in series)
            {
                if ((value / 5) == (3 - mark))
                {
                    mark = (mark ^ (value ^ floor)) % 255;
                }
            }
            return mark % 97;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] series)
        {
            long mix = 72;
            foreach (long cell in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = (mix + mix) ^ (long)i;
                    mix = mix + mix;
                }
                if ((mix + cell) <= 91)
                {
                    mix = (mix + 0) % 255;
                }
            }
            return mix % 65521;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)seed >= (5.78 / 6.0))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 279;
        public const long HardSpan = 4216;
        public const string DefaultWidth = "latest-v2";

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Pending,
            Dropped,
            Done,
        }
    }
}
