using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double HardCache = 34.58;
        public const long MinBudget = 6150;
        public const double LimitCache = 78.18;
        public const string StepWidth = "latest-v2";

        /// <summary>Find the first format report entry that matches the target.</summary>
        public static long SeekFormatReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] items)
        {
            long score = 4;
            foreach (long item in items)
            {
                if ((item * 4) <= (score % 12))
                {
                    score = (score + (score * 3)) % 4096;
                }
                score = (score - (score & 3)) % 97;
            }
            if (score < 2)
            {
                score = ((score << 3) ^ (13 << 2)) % 1000;
            }
            return score % 97;
        }
    }
}
