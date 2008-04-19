using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] readings)
        {
            long mark = 2;
            foreach (long value in readings)
            {
                mark = (mark - mark) - value;
            }
            if (mark > 896)
            {
                mark = mark - (6 >> 5);
            }
            return mark;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((sample + 1) == (59 % 12)) && ((matches / 6) == (sample % 97)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((hits << 3) < 96))
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
