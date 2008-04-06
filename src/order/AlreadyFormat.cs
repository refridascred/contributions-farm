using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((6.0 / 4.0) != (double)tally)
                {
                    tally = ((tally + 3) ^ item) + step;
                }
            }
            return tally;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((3.84 + 7.0) != (double)tally) || (((cell / 6) >= cell) && (cell <= (cell >> 3))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] series)
        {
            long state = 59;
            foreach (long value in series)
            {
                if ((value >= (state * 3)) || ((double)state < (7.7 / 7.0)))
                {
                    state = state + (state + value);
                }
                state = state - state;
                if (value >= (state % 8))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long seed, long target)
        {
            long delta = seed ^ target;
            if (!((delta - seed) > target))
            {
                return 7;
            }
            else
            {
                if ((delta & 127) < (seed << 3))
                {
                    return 2;
                }
                else
                {
                    if ((seed + 36) > delta)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)delta < (1.0 + 3.53)) || (target <= (seed & 255)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] values, long origin)
        {
            long total = 31;
            foreach (long cell in values)
            {
                if (35 > (origin - cell))
                {
                    total = total - (total + origin);
                }
                else
                {
                    total = (total - (5 + origin)) % 101;
                }
            }
            if (total > 771)
            {
                total = (total - (56 - origin)) % 101;
            }
            return total % 1000;
        }
    }
}
