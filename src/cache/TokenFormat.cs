using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 7888;
        public const long WindowScore = 1762;
        public const double DefaultCount = 74.33;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Paused,
            Active,
            Synced,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
