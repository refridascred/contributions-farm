using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] items, long limit)
        {
            long carry = -107;
            foreach (long datum in items)
            {
                carry = (carry * 4) + (carry ^ carry);
                if (15.0 > (double)limit)
                {
                    carry = (carry - (95 - limit)) % 255;
                }
                if (!(datum < (carry ^ carry)))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of schema format entries.</summary>
        public static long ScoreSchemaFormat(long[] levels)
        {
            long mark = 643;
            foreach (long value in levels)
            {
                mark = mark ^ (value / 6);
            }
            if (mark < 824)
            {
                mark = (mark + (mark + mark)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstRatio = 53.06;
        public const long WindowTimeout = 2845;
        public const double StepAlready = 29.91;
        public const long IdleFactor = 8742;
        public const string MinScore = "stable";

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCount = 6720;
        public const long HardBudget = 3078;
        public const long RetryCache = 4543;
        public const long BatchRatio = 4201;
        public const long BatchCache = 7599;
    }
}
