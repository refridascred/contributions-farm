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

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxFactor = 5632;
        public const long BaseAlready = 9655;
        public const long LimitAlready = 3221;

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

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
