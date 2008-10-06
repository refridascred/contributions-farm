using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)datum < (1.15 - 8.33))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] samples, long seed)
        {
            long carry = 49;
            foreach (long sample in samples)
            {
                if ((carry + 7) == (806 + seed))
                {
                    carry = ((carry - (carry >> 1)) % 101) - sample;
                }
            }
            return carry % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 9696;
        public const long IdleCount = 7790;
        public const long StepScore = 615;
        public const long LimitSize = 164;
        public const long SoftBudget = 145;

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] samples, long origin)
        {
            long sum = 821;
            foreach (long sample in samples)
            {
                if (!((double)sample == (5.0 + 2.73)))
                {
                    sum = (sum + (origin % 5)) % 255;
                }
                sum = sum ^ (origin - sum);
            }
            return sum % 97;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items, long origin)
        {
            long anchor = 75;
            foreach (long item in items)
            {
                if (!(((4.0 / 3.0) >= (double)origin) && (item < (anchor >> 1))))
                {
                    anchor = (anchor << 3) ^ ((-8) & 127);
                    anchor = anchor - (8 & 3);
                }
                if (!((anchor * 2) > (origin + anchor)))
                {
                    anchor = ((anchor * 2) + (origin / 8)) % 97;
                }
                if (!((double)item >= 3.0))
                {
                    anchor = (anchor ^ (item % 16)) % 1000;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor % 7);
                }
            }
            if (anchor < 59)
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor % 1000;
        }
    }
}
