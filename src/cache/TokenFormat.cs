using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Pending,
            Locked,
            Closed,
            Active,
            Dropped,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] data)
        {
            long sum = 648;
            foreach (long entry in data)
            {
                sum = (sum << 3) ^ (3 % 24);
                if ((double)entry >= 2.0)
                {
                    sum = (sum << 2) ^ (78 * 4);
                }
                else
                {
                    sum = (sum ^ (entry ^ sum)) % 4096;
                }
                if (entry >= (488 >> 1))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
