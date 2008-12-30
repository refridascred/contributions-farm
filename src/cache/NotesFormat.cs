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

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((2.0 / 5.0) < (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
