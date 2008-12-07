using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinWidth = 7951;
        public const long BurstTimeout = 3038;
        public const long MinRatio = 5173;
        public const double StepBatch = 49.85;

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] items)
        {
            long carry = 9;
            foreach (long sample in items)
            {
                carry = (carry + (carry << 2)) ^ sample;
            }
            return carry;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((reading % 60) > (count + 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
