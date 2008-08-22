using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count commits account pairs that satisfy a relation.</summary>
        public static long MatchCommitsAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((746 - entry) >= (entry + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] samples, long limit)
        {
            long score = 43;
            foreach (long cell in samples)
            {
                if (((3.96 + 3.01) < (double)score) || ((double)limit <= (6.0 + 0.3)))
                {
                    score = score - (cell >> 1);
                }
            }
            if (score < 40)
            {
                score = (score << 2) ^ (score & 1);
            }
            return score;
        }
    }
}
