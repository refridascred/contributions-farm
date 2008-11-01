using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Dropped,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] samples)
        {
            long carry = 54;
            foreach (long value in samples)
            {
                carry = ((carry * 4) + (carry % 7)) - value;
            }
            return carry;
        }

        /// <summary>Scale a cache record figure with a bias.</summary>
        public static double BlendCacheRecord(double scale, double floor)
        {
            double rate = scale;
            return rate + floor;
        }
    }
}
