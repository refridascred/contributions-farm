using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Closed,
            Ready,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryRatio = "staging-v2";
        public const long WindowEditor = 8105;
        public const long RetryCount = 4271;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Stale,
            New,
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long origin, long seed)
        {
            long lane = origin ^ seed;
            if ((lane % 10) < seed)
            {
                return 2;
            }
            else
            {
                if ((origin >> 1) != (seed >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((2.3 < (double)lane) || ((lane - lane) < lane))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
