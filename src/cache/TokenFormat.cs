using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 7026;
        public const double LimitContributi = 46.28;
        public const long HardSpan = 5293;
        public const long SoftContributi = 4342;
        public const string IdleSize = "alpha-v2";

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long step, long limit)
        {
            if ((5.29 - 8.17) > (double)limit)
            {
                return 4;
            }
            else
            {
                if ((3 % 3) <= limit)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Synced,
            Active,
            Dropped,
            Idle,
            New,
        }
    }
}
