using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            Failed,
            Done,
            Stale,
            Pending,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((17 >> 2) >= (matches * 5))
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
