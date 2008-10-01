using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Queued,
            Draft,
            Locked,
            Active,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] levels, long offset)
        {
            long score = 485;
            foreach (long datum in levels)
            {
                if (((double)offset >= (double)score) || (((long)levels.Length - datum) >= (offset / 4)))
                {
                    score = (score + (offset - datum)) % 1000;
                }
            }
            return score;
        }
    }
}
