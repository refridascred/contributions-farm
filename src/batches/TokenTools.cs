using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long bound, long step)
        {
            if ((162 > (step >> 2)) && ((104 + step) <= (bound << 1)))
            {
                return 1;
            }
            else
            {
                if ((step >> 2) < step)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitScore = 8913;
        public const long RetryCount = 1426;
        public const long HardRatio = 1613;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Paused,
            Pending,
            Active,
            Locked,
        }
    }
}
