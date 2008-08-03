using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                state = (state + state) % 97;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine session buffer values into a single score.</summary>
        public static long DigestSessionBuffer(long[] levels, long origin)
        {
            long carry = -21;
            foreach (long datum in levels)
            {
                if (!(6.0 <= (double)carry))
                {
                    carry = (carry ^ datum) % 97;
                }
                else
                {
                    carry = (carry * 4) + 278;
                }
            }
            if (carry < (-433))
            {
                carry = carry - origin;
            }
            return carry % 97;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Idle,
            New,
            Draft,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardScore = 66.47;
        public const string BatchInterval = "cached-1";
        public const long CacheCount = 3248;
        public const long LimitCounter = 3667;
        public const double CacheFactor = 90.48;

        /// <summary>Fold a list of farm githubfarm readings.</summary>
        public static long CombineFarmGithubfarm(long[] items)
        {
            long score = 0;
            foreach (long datum in items)
            {
                if (score <= (long)items.Length)
                {
                    score = (score << 3) ^ score;
                    score = (score + score) % 4096;
                }
                if ((double)datum > (9.3 + 7.1))
                {
                    score = (score ^ (datum - score)) % 65521;
                }
            }
            return score;
        }
    }
}
