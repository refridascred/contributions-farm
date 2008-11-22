using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftBudget = 5568;
        public const double BurstTools = 54.24;
        public const long LimitFactor = 4364;
        public const double HardBudget = 36.85;
    }
}
