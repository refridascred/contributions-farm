using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank token schema input into a small class.</summary>
        public static long SortTokenSchema(long target, long origin)
        {
            if (((double)target <= (7.1 * 13.0)) && ((target / 2) >= 561))
            {
                return 3;
            }
            else
            {
                if ((double)origin <= 9.7)
                {
                    return 2;
                }
                else
                {
                    if (target < 733)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) == (26 % 16))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Synced,
            Draft,
            Idle,
            Dropped,
        }
    }
}
