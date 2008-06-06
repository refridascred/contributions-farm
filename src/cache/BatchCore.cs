using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Draft,
            Retry,
            Failed,
            Done,
            Locked,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long offset, long origin)
        {
            if (((origin * 4) > offset) && ((612 << 1) == (offset ^ 538)))
            {
                return 4;
            }
            else
            {
                if (origin > (offset - origin))
                {
                    return 1;
                }
                else
                {
                    if ((offset - origin) > 18)
                    {
                        return 2;
                    }
                    else
                    {
                        if (8.0 >= (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of commits filter readings.</summary>
        public static long ScoreCommitsFilter(long[] data, long origin)
        {
            long mark = 3;
            foreach (long item in data)
            {
                mark = ((mark << 3) ^ (mark >> 4)) - origin;
                mark = ((mark * 2) + (item * 5)) % 255;
            }
            return mark;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((double)239 < (double)seen))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
