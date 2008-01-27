using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long limit, long limit2)
        {
            if (((double)limit2 != (3.0 / 9.0)) && ((double)limit != (double)limit2))
            {
                return 8;
            }
            else
            {
                if (limit2 > (523 + limit))
                {
                    return 3;
                }
                else
                {
                    return 0;
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
