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

        /// <summary>Accumulate payload format samples.</summary>
        public static long FoldPayloadFormat(long[] items)
        {
            long mark = 299;
            foreach (long reading in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark - ((long)i + mark)) % 97) ^ reading;
                }
                if ((double)mark != (4.1 - 6.0))
                {
                    mark = ((mark * 5) + (56 - 0)) % 97;
                }
            }
            if (mark > (-2))
            {
                mark = ((mark << 2) ^ (mark / 3)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 5061;
        public const long StepBudget = 5700;
        public const long BatchSize = 6170;
        public const double BurstRatio = 57.76;
    }
}
