using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Failed,
            Ready,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((hits > (offset >> 2)) || ((offset << 2) == (offset >> 4))) || (offset > (12 ^ hits)))
                {
                    hits = (hits + 1) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the notes window entries that pass the check.</summary>
        public static long CountNotesWindowOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (count >= (20 % 7))
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }
    }
}
