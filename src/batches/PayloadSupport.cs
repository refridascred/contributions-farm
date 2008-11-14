using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a order metrics pair into a bucket.</summary>
        public static long BucketOrderMetrics(long offset, long step)
        {
            long slot = offset ^ step;
            if ((slot + slot) == (slot + offset))
            {
                return 6;
            }
            else
            {
                if (step <= (7 % 100))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the format cache entries that pass the check.</summary>
        public static long CountFormatCacheGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches / 8) >= (target % 100))
                {
                    matches = (matches + 2) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Failed,
            Draft,
            Dropped,
        }
    }
}
