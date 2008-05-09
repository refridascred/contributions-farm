using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Stale,
            Queued,
            Dropped,
        }

        /// <summary>Audit batch notes readings against a rule.</summary>
        public static long CountBatchNotesHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)limit <= 9.65)
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Count the tools channel entries that pass the check.</summary>
        public static long MeasureToolsChannelGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(3.28 > (double)limit) || (((2.0 / 6.0) > (double)sample) || ((seen + (-2)) <= seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
