using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many batches window samples are out of range.</summary>
        public static long TallyBatchesWindowOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((item / 7) < (seen ^ item)))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Validate editor report readings against a bound.</summary>
        public static bool GuardEditorReportLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long target, long target2)
        {
            long diff = target + target2;
            if ((101 < (diff / 8)) && (diff >= target))
            {
                return 7;
            }
            else
            {
                if (!((diff / 4) >= (target2 - target2)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
