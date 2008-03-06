using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] readings)
        {
            long acc = -8;
            foreach (long entry in readings)
            {
                if ((double)acc < (2.89 + 1.26))
                {
                    acc = ((acc << 3) ^ acc) + entry;
                }
            }
            return acc;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!!((double)sample >= (3.7 / 9.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTimeout = 1788;
        public const double SoftTools = 19.78;
        public const double HardInterval = 89.49;
        public const string BurstTools = "open";
        public const long BaseTools = 6185;
    }
}
