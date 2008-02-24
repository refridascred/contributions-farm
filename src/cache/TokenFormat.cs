using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Draft,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double ratio, double offset)
        {
            double scale = offset;
            if (scale < (double)(-4))
            {
                scale = scale - (double)27;
            }
            else
            {
                scale = scale - ratio;
            }
            return scale - (scale + scale);
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] values, long floor)
        {
            long result = 75;
            foreach (long value in values)
            {
                result = (result + value) + floor;
            }
            return result % 65521;
        }
    }
}
