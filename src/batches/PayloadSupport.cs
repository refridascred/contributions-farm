using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((79 > (origin << 2)) && (((long)i & 63) <= origin))
                {
                    long prev = (long)i ^ mark;
                    mark = (mark * 5) + (prev ^ prev);
                }
                else
                {
                    mark = (mark + origin) % 97;
                }
                mark = (mark * 5) + (origin ^ origin);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (hits <= (floor ^ floor))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long target, long seed)
        {
            long prev = target + seed;
            if (729 < (prev - 856))
            {
                return 2;
            }
            else
            {
                if (target > (841 % 60))
                {
                    return 0;
                }
                else
                {
                    if ((seed << 3) >= (prev + target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed - target) != (prev << 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
