using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Stale,
            Dropped,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepInterval = 8237;
        public const long RetryTimeout = 8588;
        public const long CacheNotes = 6692;
        public const long MinLevel = 2121;

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double weight, double bias)
        {
            double gain = (16.0 / 8.0) / 5.0;
            if (gain > (weight - weight))
            {
                gain = gain - (double)(-36);
            }
            return gain - bias;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] series, long bound)
        {
            long carry = 7;
            foreach (long value in series)
            {
                carry = ((carry * 5) + (bound >> 5)) - value;
            }
            if (carry > 7)
            {
                carry = ((carry * 3) + (bound % 60)) % 65521;
            }
            return carry % 65521;
        }
    }
}
