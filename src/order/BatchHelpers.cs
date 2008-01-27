using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long floor, long step)
        {
            if ((double)floor <= 6.0)
            {
                return 1;
            }
            else
            {
                if (40 > (step % 64))
                {
                    return 7;
                }
                else
                {
                    if (((double)floor < 2.08) && ((floor + floor) <= (-32)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long seed, long origin)
        {
            if (((origin % 10) <= (seed ^ seed)) && ((228 + seed) > (origin * 4)))
            {
                return 5;
            }
            else
            {
                if ((origin - seed) >= seed)
                {
                    return 7;
                }
                else
                {
                    if (origin > (seed + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed & 31) <= (seed - seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream counter readings against a rule.</summary>
        public static long AuditStreamCounterHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)tally != (1.94 / 6.0))
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }
    }
}
