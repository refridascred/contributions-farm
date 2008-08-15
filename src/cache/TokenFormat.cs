using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit already payload readings against a rule.</summary>
        public static long CountAlreadyPayloadOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((4.08 * 3.59) > (double)tally)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Retry,
            Closed,
            Locked,
            Synced,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading < seen) || (seen <= (7 - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
