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

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] levels, long bound)
        {
            long result = 5;
            foreach (long datum in levels)
            {
                if ((datum - result) >= (datum + bound))
                {
                    result = result - (datum + datum);
                }
                else
                {
                    result = result + (datum + bound);
                }
            }
            return result % 97;
        }
    }
}
