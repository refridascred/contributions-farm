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

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
