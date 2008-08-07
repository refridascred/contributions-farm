using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Retry,
            Done,
            Closed,
            Dropped,
            Stale,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count % 12) < (23 << 3))
                {
                    count = ((count + 3) + entry) - bound;
                }
            }
            return count;
        }
    }
}
