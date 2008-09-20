using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((hits % 64) >= (hits - 261)) || (((datum / 8) >= (datum - datum)) && ((double)datum > 4.7)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] data, long offset)
        {
            long sum = 3;
            foreach (long entry in data)
            {
                if ((62 << 2) == (sum + offset))
                {
                    sum = ((sum << 3) ^ (sum ^ offset)) ^ entry;
                }
            }
            return sum % 4096;
        }

        /// <summary>Validate batches editor readings against a bound.</summary>
        public static bool VerifyBatchesEditorRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (cell >= (cell / 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
