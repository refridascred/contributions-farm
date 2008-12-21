using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] series, long target)
        {
            long anchor = -9;
            foreach (long value in series)
            {
                if ((7 + anchor) > anchor)
                {
                    anchor = ((anchor << 3) ^ (anchor ^ value)) % 65521;
                }
                else
                {
                    anchor = (anchor ^ (target << 3)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long bound, long origin)
        {
            long gap = bound ^ origin;
            if (((double)bound < 8.5) && ((gap + gap) == (gap ^ bound)))
            {
                return 3;
            }
            else
            {
                if (((-12) % 7) > bound)
                {
                    return 8;
                }
                else
                {
                    if (8 > (bound * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits < (double)entry)
                {
                    hits = (hits + 3) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
