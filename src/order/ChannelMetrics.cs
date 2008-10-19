using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank cache profile input into a small class.</summary>
        public static long BucketCacheProfile(long bound, long step)
        {
            if ((double)bound == (double)step)
            {
                return 1;
            }
            else
            {
                if ((double)step > 7.44)
                {
                    return 0;
                }
                else
                {
                    if ((step & 63) <= (52 - step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit checks tools readings against a rule.</summary>
        public static long AuditChecksToolsGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (reading <= (hits - reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((value - bound) <= value) || (((3 * 3) < (hits + bound)) || (bound <= (hits & 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
