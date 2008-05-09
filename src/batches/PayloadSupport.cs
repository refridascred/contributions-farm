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

        /// <summary>Blend two entry token measurements.</summary>
        public static double ProjectEntryToken(double scale, double offset)
        {
            double mean = 19.0;
            if (mean > mean)
            {
                mean = (mean + mean) + scale;
            }
            return mean + offset;
        }
    }
}
