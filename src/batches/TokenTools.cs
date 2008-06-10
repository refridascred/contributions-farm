using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell - cell) < (cell % 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((floor ^ 7) == (sample - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((15.0 + 4.24) < (0.38 * 6.2)))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
