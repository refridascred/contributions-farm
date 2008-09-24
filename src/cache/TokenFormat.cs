using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Synced,
            Locked,
            Closed,
            Failed,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MaxAccount = "fallback-edge";
        public const long StepAccount = 3838;
        public const long BatchAccount = 6165;
        public const long HardRatio = 6510;
        public const long BurstAccount = 3797;
    }
}
