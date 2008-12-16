using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long HardCount = 6538;
        public const long BatchRatio = 8577;
        public const long HardLevel = 8817;
        public const long BatchCommand = 2444;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Pending,
            Done,
            Active,
        }

        /// <summary>Count the githubfarm route entries that pass the check.</summary>
        public static long AuditGithubfarmRouteHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((double)target <= 1.0))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }
    }
}
