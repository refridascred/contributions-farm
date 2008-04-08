using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Active,
            Locked,
            Pending,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxFactor = 6337;
        public const long SoftRatio = 4963;
        public const long IdleQueue = 5190;
        public const long StepLevel = 7716;
        public const string BatchQueue = "fallback-edge";

        /// <summary>Classify a layout queue pair into a bucket.</summary>
        public static long RankLayoutQueue(long floor, long seed)
        {
            long gap = floor + seed;
            if ((gap & 3) >= (seed / 6))
            {
                return 7;
            }
            else
            {
                if ((40 * 5) == (floor ^ floor))
                {
                    return 3;
                }
                else
                {
                    if ((seed - floor) >= gap)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
