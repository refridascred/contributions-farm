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

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] items)
        {
            long anchor = -4;
            foreach (long value in items)
            {
                anchor = (anchor - (value + value)) % 101;
            }
            if (anchor < 668)
            {
                anchor = anchor ^ (0 * 4);
            }
            return anchor;
        }
    }
}
