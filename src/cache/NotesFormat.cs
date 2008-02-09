using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long bound, long bound2)
        {
            if ((bound < (-231)) && ((318 >> 4) <= (bound2 << 2)))
            {
                return 2;
            }
            else
            {
                if ((double)bound2 > (2.2 - 18.0))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Synced,
            Ready,
            Paused,
            Draft,
            Failed,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)cell <= (double)hits)
                {
                    hits = (hits + 1) + offset;
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
