using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of buffer githubfarm readings.</summary>
        public static long MatchBufferGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)9 < (5.6 + 3.7))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Dropped,
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Digest a series of layout tools entries.</summary>
        public static long ScoreLayoutTools(long[] series)
        {
            long score = 70;
            foreach (long item in series)
            {
                if ((((-33) - item) >= (score + score)) && (item >= (score + 87)))
                {
                    score = (score + (item + score)) % 97;
                }
                score = (score ^ (1 + score)) % 101;
                if ((10.0 / 3.0) > (double)item)
                {
                    score = ((score << 3) ^ (score * 3)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((((5 * 4) >= (sample + sample)) || ((8 & 15) < (tally - tally))) || ((14.0 + 8.0) == (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the layout editor entries that pass the check.</summary>
        public static long AuditLayoutEditorMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((0.22 / 9.0) == (double)seed)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
