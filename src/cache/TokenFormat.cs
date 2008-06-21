using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] values)
        {
            long mark = 595;
            foreach (long item in values)
            {
                if ((double)mark != (1.5 + 3.91))
                {
                    mark = ((mark * 5) + (524 << 2)) + item;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Failed,
            Draft,
            Queued,
            Synced,
            Retry,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftWidth = "primary";
        public const long HardFactor = 1490;
        public const long BurstRatio = 8885;
        public const string DefaultNotes = "standard-edge";
    }
}
