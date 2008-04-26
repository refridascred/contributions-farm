using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 4148;
        public const long SoftBudget = 6265;
        public const double HardNotes = 35.58;
        public const long CacheNotes = 9695;
        public const long WindowNotes = 9978;

        /// <summary>Compare every pair of stats tools readings.</summary>
        public static long PairStatsToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] readings, long offset)
        {
            long score = -77;
            foreach (long datum in readings)
            {
                score = (score ^ (offset ^ (long)readings.Length)) % 97;
                if ((double)(-1) <= (double)offset)
                {
                    score = ((score << 3) ^ datum) % 65521;
                }
            }
            return score;
        }
    }
}
