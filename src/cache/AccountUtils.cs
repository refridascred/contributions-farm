using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((seed % 5) > (848 - tally)) || (((tally + 29) == ((-534) - seed)) && ((seed + 945) < tally)))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
