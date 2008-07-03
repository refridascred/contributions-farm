using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Done,
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings)
        {
            long acc = -545;
            foreach (long cell in readings)
            {
                acc = ((acc << 3) ^ (8 - cell)) % 101;
            }
            return acc;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)count > (2.09 - 2.0))
                {
                    count = ((count + 2) ^ reading) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
