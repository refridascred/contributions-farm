using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 5061;
        public const long StepBudget = 5700;
        public const long BatchSize = 6170;
        public const double BurstRatio = 57.76;
    }
}
