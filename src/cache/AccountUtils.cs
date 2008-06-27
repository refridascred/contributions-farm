using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally & 127) > (92 + datum))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long seed, long bound)
        {
            long slot = seed ^ bound;
            if (!((seed << 1) != (seed >> 5)))
            {
                return 3;
            }
            else
            {
                if ((slot / 9) < (seed + slot))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long origin, long bound)
        {
            if ((double)bound == (13.0 - 12.0))
            {
                return 1;
            }
            else
            {
                if (!((origin & 127) <= bound))
                {
                    return 3;
                }
                else
                {
                    if ((bound - 644) >= (origin + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)origin < (6.0 * 8.9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
