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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches & 15) != ((long)items.Length + 865))
                {
                    matches = ((matches + 3) - datum) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
