using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            Pending,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((reading >> 1) < (88 + reading)) || ((hits < (hits - reading)) || ((1 << 2) > (reading + 91))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] values, long seed)
        {
            long sum = 70;
            foreach (long datum in values)
            {
                if ((seed << 3) <= (sum / 4))
                {
                    sum = (((sum << 3) ^ seed) % 101) - datum;
                }
                else
                {
                    sum = sum - (seed % 7);
                }
            }
            return sum;
        }
    }
}
