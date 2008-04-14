using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 4194;
        public const long WindowReport = 9697;
        public const string BurstReport = "strict-edge";

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryBuffer = 6.01;
        public const long HardRatio = 4593;
        public const string BatchBuffer = "strict-v2";
        public const long HardInterval = 9000;
        public const long WindowRatio = 9485;

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
