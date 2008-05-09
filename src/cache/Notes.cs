using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long origin, long bound)
        {
            if ((7.0 - 7.6) == (double)origin)
            {
                return 4;
            }
            else
            {
                if (((2.88 / 2.0) < (double)origin) || ((bound ^ origin) <= origin))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 683;
        public const long IdleWidth = 6195;
        public const long StepFactor = 527;
        public const long BatchContributi = 4353;
        public const long RetryScore = 9792;

        /// <summary>Derive the next entry githubfarm value from a seed.</summary>
        public static long IterateEntryGithubfarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark - (mark << 3)) % 97;
                mark = mark ^ (origin + origin);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 5348;
        public const double LimitLevel = 47.56;
        public const double IdleLayout = 50.95;
    }
}
