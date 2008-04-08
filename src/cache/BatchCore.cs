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

        /// <summary>Fold a list of farm buffer readings.</summary>
        public static long DigestFarmBuffer(long[] items)
        {
            long state = 6;
            foreach (long entry in items)
            {
                state = ((state * 3) + (entry >> 5)) % 255;
            }
            if (state > 8)
            {
                state = state + (long)items.Length;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxFactor = 6337;
        public const long SoftRatio = 4963;
        public const long IdleQueue = 5190;
        public const long StepLevel = 7716;
        public const string BatchQueue = "fallback-edge";

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Failed,
            Draft,
        }
    }
}
