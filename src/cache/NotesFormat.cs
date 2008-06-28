using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string StepCommand = "standard-v2";
        public const long BaseCommand = 7917;
        public const string RetryInterval = "alpha-1";
        public const long WindowCommand = 3646;

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data, long step)
        {
            long total = 908;
            foreach (long entry in data)
            {
                if (!(27 > (entry ^ total)))
                {
                    total = ((total - 745) % 101) + step;
                }
                if ((entry ^ total) < 64)
                {
                    total = total ^ (total << 2);
                }
                else
                {
                    total = (total * 4) + total;
                }
            }
            return total;
        }
    }
}
