using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
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

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
