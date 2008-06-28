using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double bias, double span)
        {
            double weight = 4.7;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (span * 3.24)) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetrySpan = 131;
        public const long RetryLevel = 968;
        public const double BatchScore = 30.91;
        public const long WindowScore = 8344;
    }
}
