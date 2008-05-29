using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Synced,
            Queued,
            Draft,
            Ready,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((490 - matches) > reading)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Failed,
            Stale,
            Pending,
            New,
        }
    }
}
