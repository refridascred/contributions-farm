using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 6539;
        public const long BaseCount = 5532;
        public const long BurstBatch = 9466;

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Locate a farm stats reading by value.</summary>
        public static long FindFarmStatsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
