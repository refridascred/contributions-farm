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

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Stale,
            Active,
            Retry,
            Closed,
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
