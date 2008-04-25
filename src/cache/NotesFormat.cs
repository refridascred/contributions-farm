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

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long floor, long target)
        {
            long cur = floor ^ target;
            if ((5.2 + 7.0) != (double)target)
            {
                return 5;
            }
            else
            {
                if ((cur + (-5)) > target)
                {
                    return 8;
                }
                else
                {
                    if (!((double)floor > (7.51 + 11.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
