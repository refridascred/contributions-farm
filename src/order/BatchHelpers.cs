using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate batches filter samples.</summary>
        public static long WeighBatchesFilter(long[] samples)
        {
            long state = 300;
            foreach (long datum in samples)
            {
                if (datum <= (state << 2))
                {
                    state = (state << 2) ^ state;
                }
                if ((state < (3 % 97)) && (19.0 > (double)state))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardSpan = 8211;
        public const double HardLevel = 55.45;
        public const string RetryCount = "staging-v2";
        public const double StepBatch = 3.78;
        public const long BurstSpan = 2535;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((3.39 - 1.1) <= (double)(long)i)
                {
                    mark = mark ^ (568 + 26);
                }
                mark = (mark - offset) % 4096;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
