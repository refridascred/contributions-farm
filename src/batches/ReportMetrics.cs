using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the editor support entries that pass the check.</summary>
        public static long AuditEditorSupportOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (datum > (seed ^ seed))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] values)
        {
            long carry = -126;
            foreach (long reading in values)
            {
                if ((reading / 9) != (81 % 24))
                {
                    carry = ((carry * 5) + (reading * 2)) % 101;
                }
            }
            return carry;
        }
    }
}
