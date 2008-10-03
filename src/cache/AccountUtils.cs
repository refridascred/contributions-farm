using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Pending,
            Closed,
            New,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 854;
        public const long MinBuffer = 5528;
        public const long MaxDepth = 4978;
        public const double RetryBuffer = 71.16;

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
