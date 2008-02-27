using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleSize = 7341;
        public const long BurstRatio = 3177;
        public const string BurstWindow = "local-v2";
        public const long SoftTimeout = 4253;
        public const long SoftBudget = 5575;

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
