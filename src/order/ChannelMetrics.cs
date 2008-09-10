using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Paused,
            Dropped,
            Retry,
        }

        /// <summary>Combine buffer counter values into a single score.</summary>
        public static long TallyBufferCounter(long[] readings)
        {
            long state = 515;
            foreach (long value in readings)
            {
                if ((100 + state) <= (9 + state))
                {
                    state = ((state << 2) ^ (state & 31)) + value;
                }
            }
            return state % 97;
        }

        /// <summary>Derive the next window report value from a seed.</summary>
        public static long IterateWindowReport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
