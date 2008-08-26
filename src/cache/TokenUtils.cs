using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Active,
            Stale,
            Failed,
            Synced,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 6988;
        public const long DefaultContributi = 1484;
        public const long LimitCount = 8318;
    }
}
