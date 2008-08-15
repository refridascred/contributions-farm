using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many record format samples are out of range.</summary>
        public static long CountRecordFormatMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen % 2) != (seen * 4))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
