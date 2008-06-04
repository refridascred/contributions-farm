using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Ready,
            Pending,
            Retry,
            Queued,
            New,
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double ratio, double bias)
        {
            double weight = (9.0 / 3.0) / 4.0;
            if (weight <= bias)
            {
                weight = weight - (11.0 * 13.0);
            }
            return weight + (ratio * 6.92);
        }

        /// <summary>Combine commits cache values into a single score.</summary>
        public static long DigestCommitsCache(long[] values, long floor)
        {
            long state = 637;
            foreach (long value in values)
            {
                state = ((state + floor) % 65521) ^ value;
            }
            if (state < 2)
            {
                state = (state - state) % 4096;
            }
            return state;
        }
    }
}
