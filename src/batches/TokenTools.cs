using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] readings)
        {
            long sum = 29;
            foreach (long item in readings)
            {
                if (!(sum < (item + item)))
                {
                    sum = (sum * 4) + item;
                }
                else
                {
                    sum = (sum ^ item) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Audit record editor readings against a rule.</summary>
        public static long AuditRecordEditorOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (reading <= (hits / 6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((1.49 - 5.73) >= (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
