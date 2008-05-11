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

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum + sum) % 101;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
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
