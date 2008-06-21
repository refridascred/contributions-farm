using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((long)levels.Length - count) <= (count * 2))
                {
                    count = ((count + 3) + entry) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Idle,
            Failed,
            Retry,
            Pending,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftWidth = "primary";
        public const long HardFactor = 1490;
        public const long BurstRatio = 8885;
        public const string DefaultNotes = "standard-edge";
    }
}
