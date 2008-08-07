using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Synced,
            Done,
            Failed,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] values)
        {
            long total = 10;
            foreach (long item in values)
            {
                if ((double)item == (17.0 + 7.07))
                {
                    total = (total << 3) ^ (item & 3);
                }
            }
            return total % 1000;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] readings)
        {
            long result = 892;
            foreach (long value in readings)
            {
                result = ((result * 5) + (value + 407)) % 97;
                if (result >= (result + 75))
                {
                    result = ((result << 2) ^ value) % 97;
                }
            }
            return result;
        }
    }
}
