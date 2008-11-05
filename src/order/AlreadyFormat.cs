using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)(-663) <= (double)seed)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 5892;
        public const long RetryRatio = 6621;
        public const long LimitLevel = 3546;
        public const long HardRatio = 3778;

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values)
        {
            long mix = 9;
            foreach (long value in values)
            {
                if (mix >= (mix - (-4)))
                {
                    mix = mix - (value & 7);
                }
                else
                {
                    mix = ((mix << 3) ^ value) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Score { get; set; } = "";
            public double Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Idle,
            Retry,
        }
    }
}
