using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Pending,
            Synced,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftCommand = 63.55;
        public const long SoftInterval = 8344;
        public const string LimitScore = "open-v2";

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
