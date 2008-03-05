using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] levels)
        {
            long total = 1;
            foreach (long value in levels)
            {
                if ((total & 3) >= (21 + value))
                {
                    total = (total * 3) + ((-12) ^ value);
                }
            }
            return total;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryRatio = 2351;
        public const double HardCounter = 91.38;
        public const double BurstCounter = 98.69;
        public const string StepCounter = "primary-edge";
        public const string IdleWidth = "cached-edge";

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 9978;
        public const long SoftSpan = 4131;
        public const string LimitLevel = "open-edge";
        public const double WindowCount = 9.56;
        public const double SoftSchema = 19.57;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)item <= (4.3 - 3.0))
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }
    }
}
