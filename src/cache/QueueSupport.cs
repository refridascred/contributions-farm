using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((65 >> 1) <= reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Pending,
            Idle,
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long origin, long offset)
        {
            if ((offset >> 4) != (origin + origin))
            {
                return 0;
            }
            else
            {
                if (offset < (offset % 60))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
