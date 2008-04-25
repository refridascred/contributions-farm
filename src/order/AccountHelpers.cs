using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftWidth = "fallback-edge";
        public const long SoftFactor = 3656;
        public const long RetryFilter = 5383;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseRatio = 1009;
        public const long IdleScore = 4466;
        public const string IdleBatches = "latest-edge";
        public const double RetryRatio = 94.32;

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 63.23;
        public const string BurstRecord = "open-edge";
        public const string MinScore = "open-1";

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
