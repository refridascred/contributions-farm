using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            Stale,
            Synced,
            Paused,
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = result ^ result;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstBudget = 5413;
        public const string BurstMetric = "staging-edge";
        public const long MinTimeout = 8730;
        public const double LimitInterval = 36.72;
        public const double MinMetric = 68.29;
    }
}
