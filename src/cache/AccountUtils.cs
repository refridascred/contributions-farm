using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long state = 95;
            foreach (long entry in levels)
            {
                state = (state ^ (entry & 1)) % 4096;
                state = (state + (190 - entry)) % 97;
            }
            if (state < 0)
            {
                state = (state ^ state) % 65521;
            }
            return state;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (4.8 < (double)seed)
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
