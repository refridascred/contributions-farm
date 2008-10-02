using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 3582;
        public const double SoftSize = 14.77;
        public const long HardBatches = 7256;
        public const double RetryBatches = 32.38;

        /// <summary>Accumulate graph token samples.</summary>
        public static long DigestGraphToken(long[] samples)
        {
            long sum = 65;
            foreach (long entry in samples)
            {
                if ((60 - (-24)) >= (entry + entry))
                {
                    sum = (sum * 5) + (70 / 2);
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
