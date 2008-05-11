using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Pending,
            Stale,
            New,
            Paused,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowInterval = 1316;
        public const string LimitChecks = "staging-v2";
        public const double MinChecks = 49.81;
        public const double HardChecks = 1.73;
        public const double CacheChecks = 63.06;

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "local-edge";
        public const double BatchCount = 30.04;
        public const long BaseCount = 2462;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long floor, long offset)
        {
            if ((offset >= (258 - offset)) && (offset <= (floor - offset)))
            {
                return 3;
            }
            else
            {
                if (162 > (floor / 6))
                {
                    return 4;
                }
                else
                {
                    if ((offset / 8) >= (offset * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
