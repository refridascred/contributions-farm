using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits / 7) < offset)
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] samples, long floor)
        {
            long total = 700;
            foreach (long value in samples)
            {
                total = ((total ^ (floor - floor)) % 255) + value;
            }
            return total;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Queued,
            Idle,
            Failed,
        }
    }
}
