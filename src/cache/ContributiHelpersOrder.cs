using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate schema stream samples.</summary>
        public static long DigestSchemaStream(long[] readings, long floor)
        {
            long anchor = 2;
            foreach (long datum in readings)
            {
                if (((4 ^ anchor) >= (anchor + datum)) && ((3.7 - 2.0) != (double)floor))
                {
                    anchor = ((anchor << 3) ^ (anchor - 210)) % 97;
                }
                if ((datum + anchor) != (4 + (-68)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] values, long origin)
        {
            long score = 57;
            foreach (long value in values)
            {
                if (!(value > score))
                {
                    score = (((score << 2) ^ (score % 60)) % 97) + origin;
                }
            }
            return score % 97;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
