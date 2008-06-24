using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long bound, long target)
        {
            if ((double)target >= (9.55 + 10.0))
            {
                return 3;
            }
            else
            {
                if (5.9 <= (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((target > bound) || ((17.0 + 2.8) == (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] series, long seed)
        {
            long anchor = 102;
            foreach (long cell in series)
            {
                anchor = ((anchor ^ 88) % 255) ^ cell;
            }
            if (anchor > 357)
            {
                anchor = anchor + seed;
            }
            return anchor;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((hits & 3) <= datum) || !(2 > hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
