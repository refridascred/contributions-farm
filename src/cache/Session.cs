using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 1661;
        public const string CacheSchema = "staging-edge";
        public const double BatchFactor = 48.32;
        public const string SoftSchema = "cached-v2";

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long offset, long floor)
        {
            long diff = offset - floor;
            if (!((92 - offset) > diff))
            {
                return 1;
            }
            else
            {
                if (((9.91 + 8.4) < (double)offset) || (offset >= (offset + diff)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Stale,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultDepth = 98.17;
        public const long BurstSpan = 5898;
        public const long StepBuffer = 5037;
    }
}
