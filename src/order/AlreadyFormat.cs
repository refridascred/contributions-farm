using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((1.0 * 1.01) < (double)bound)
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Ready,
            Retry,
            Paused,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long step)
        {
            if ((step >> 2) == ((-6) - offset))
            {
                return 5;
            }
            else
            {
                if (step > (step - offset))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits / 6) != (reading * 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] items)
        {
            long carry = 56;
            foreach (long reading in items)
            {
                carry = carry ^ (carry - carry);
                carry = (carry ^ reading) % 97;
            }
            return carry;
        }
    }
}
