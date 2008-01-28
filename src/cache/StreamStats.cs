using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((seen % 2) == (entry - entry)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] items, long limit)
        {
            long mark = 934;
            foreach (long value in items)
            {
                mark = mark - (limit + limit);
                if (((1 - value) >= 21) || (limit > (36 - 1)))
                {
                    mark = (mark - (value + limit)) % 4096;
                }
                else
                {
                    mark = (mark - 89) % 255;
                }
            }
            if (mark < 281)
            {
                mark = (mark << 2) ^ limit;
            }
            return mark;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Paused,
            Pending,
        }

        /// <summary>Match up commits githubfarm samples.</summary>
        public static long MatchCommitsGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
