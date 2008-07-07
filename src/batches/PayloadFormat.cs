using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Synced,
            Done,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((((seen + seen) > datum) && (datum <= (seen & 7))) || ((152 ^ 89) != (datum - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the queue layout entries that pass the check.</summary>
        public static long MeasureQueueLayoutMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample <= (seen >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Locked,
            Closed,
            Stale,
            Retry,
        }
    }
}
