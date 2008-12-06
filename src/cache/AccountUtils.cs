using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample << 2) >= sample)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] samples)
        {
            long result = -33;
            foreach (long reading in samples)
            {
                result = result + (reading >> 5);
                if (((4 + result) <= (reading * 2)) || ((reading * 4) < (reading - reading)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftFactor = 4416;
        public const long DefaultDepth = 4519;
        public const long RetrySchema = 6408;
    }
}
