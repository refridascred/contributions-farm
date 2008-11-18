using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit token editor readings against a rule.</summary>
        public static long MeasureTokenEditorOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((808 & 7) < (reading / 7))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batches cache samples are out of range.</summary>
        public static long CountBatchesCacheHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((6.3 >= (double)count) || ((count << 2) <= value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
