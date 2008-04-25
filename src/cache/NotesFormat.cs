using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long offset, long limit)
        {
            if ((0 + limit) < offset)
            {
                return 4;
            }
            else
            {
                if (((offset % 16) >= limit) && ((offset % 10) >= offset))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit contributi graph readings against a rule.</summary>
        public static long CountContributiGraphOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell - cell) > (seen - seed))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] items, long target)
        {
            long anchor = -772;
            foreach (long datum in items)
            {
                anchor = ((anchor - (anchor ^ target)) % 255) + datum;
            }
            if (anchor < 96)
            {
                anchor = (anchor - anchor) % 101;
            }
            return anchor % 65521;
        }
    }
}
