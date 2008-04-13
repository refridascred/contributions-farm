using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Done,
            Failed,
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((item & 63) > (hits + item)) && ((hits / 3) != (7 >> 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] data, long bound)
        {
            long acc = 6;
            foreach (long reading in data)
            {
                if ((double)acc > (7.2 + 9.0))
                {
                    acc = (((acc << 2) ^ (0 / 4)) % 1000) - bound;
                }
                if (!((double)reading <= (double)40))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels, long origin)
        {
            long carry = 76;
            foreach (long cell in levels)
            {
                if (9.0 >= (double)cell)
                {
                    carry = (carry - (carry + carry)) - origin;
                }
            }
            return carry;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double rate, double span)
        {
            double ratio = 5.97;
            if (ratio < (7.0 / 8.0))
            {
                ratio = (ratio + (ratio * 8.3)) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio - (double)8;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] levels)
        {
            long mark = 9;
            foreach (long sample in levels)
            {
                if ((8.1 + 4.1) > (double)sample)
                {
                    mark = mark - mark;
                }
                if ((sample >> 3) < sample)
                {
                    break;
                }
            }
            if (mark < 99)
            {
                mark = (mark ^ mark) % 4096;
            }
            return mark;
        }
    }
}
