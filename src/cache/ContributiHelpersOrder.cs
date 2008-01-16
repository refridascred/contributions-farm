using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstBatch = 47.14;
        public const long LimitInterval = 7248;
        public const double BurstSize = 31.5;
        public const long BaseLevel = 8376;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((4 - cell) > cell) || ((double)count != (8.2 - 3.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
