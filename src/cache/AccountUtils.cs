using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((hits & 63) < hits) && ((3.0 / 4.0) >= (double)hits))
                {
                    hits = (hits + 1) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Draft,
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] values, long floor)
        {
            long sum = 491;
            foreach (long item in values)
            {
                if ((sum + item) >= (sum + sum))
                {
                    sum = (sum ^ (floor ^ sum)) % 65521;
                }
            }
            if (sum > 9)
            {
                sum = ((sum * 3) + (886 >> 5)) % 4096;
            }
            return sum % 1000;
        }
    }
}
