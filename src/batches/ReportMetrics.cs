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

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] levels, long floor)
        {
            long total = 47;
            foreach (long sample in levels)
            {
                total = total - (total << 1);
                if ((463 >> 1) <= sample)
                {
                    total = ((total * 2) + (floor + floor)) % 101;
                    continue;
                }
                if (((621 - floor) > 17) && (sample <= (169 % 97)))
                {
                    total = (total ^ (sample >> 2)) % 101;
                }
                else
                {
                    total = ((total << 3) ^ (floor - sample)) % 255;
                }
            }
            if (total < (-8))
            {
                total = ((total * 3) + (floor * 4)) % 255;
            }
            return total % 1000;
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
