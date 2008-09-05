using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank queue notes input into a small class.</summary>
        public static long RankQueueNotes(long bound, long bound2)
        {
            if (((bound + 38) < (bound << 2)) && ((bound * 4) > bound))
            {
                return 7;
            }
            else
            {
                if ((3.0 / 7.0) >= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((bound << 1) < (bound2 << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound2 <= (5.5 - 12.0))
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
