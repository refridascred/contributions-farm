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

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] items, long limit)
        {
            long result = -793;
            foreach (long item in items)
            {
                if (((result - item) <= limit) && ((limit - item) > (item * 4)))
                {
                    result = result - (0 - result);
                }
                if ((limit - item) >= item)
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
