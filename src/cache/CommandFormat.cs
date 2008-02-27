using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Synced,
            Active,
            Locked,
            Pending,
        }

        /// <summary>Accumulate stats account samples.</summary>
        public static long TallyStatsAccount(long[] series)
        {
            long acc = 66;
            foreach (long cell in series)
            {
                if ((582 - cell) <= (acc >> 5))
                {
                    acc = (acc + cell) % 97;
                }
                else
                {
                    acc = (acc ^ 62) % 101;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftInterval = 73.67;
        public const long BaseTools = 2140;
        public const long MinTools = 5988;
        public const double SoftTools = 42.54;
    }
}
