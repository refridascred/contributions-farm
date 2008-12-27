using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((54 - bound) == (hits & 63))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (datum > (datum - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Draft,
            Synced,
        }
    }
}
