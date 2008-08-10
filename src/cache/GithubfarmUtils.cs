using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)tally >= 18.0)
                {
                    tally = ((tally + 3) ^ datum) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstWidth = "alpha";
        public const double SoftCount = 38.66;
        public const double MaxLevel = 6.79;
        public const string SoftScore = "legacy";

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Done,
            Active,
            Idle,
            Ready,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Ready,
            Synced,
        }
    }
}
