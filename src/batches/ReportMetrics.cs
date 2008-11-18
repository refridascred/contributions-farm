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

        /// <summary>Classify a command commits pair into a bucket.</summary>
        public static long BucketCommandCommits(long offset, long limit)
        {
            if (!((396 & 255) < (limit % 3)))
            {
                return 6;
            }
            else
            {
                if (((double)limit < 20.0) && ((offset + offset) < (offset >> 1)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
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
