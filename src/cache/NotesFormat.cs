using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 5610;
        public const long IdleRoute = 5701;
        public const double BaseRoute = 50.27;
        public const double LimitWidth = 13.78;
        public const long RetryTimeout = 6650;

        /// <summary>Count stats profile pairs that satisfy a relation.</summary>
        public static long OverlapStatsProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Closed,
            Done,
            Queued,
        }
    }
}
