using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] series, long target)
        {
            long acc = 853;
            foreach (long entry in series)
            {
                acc = (acc + (target + acc)) % 1000;
                if ((acc + acc) == (target - acc))
                {
                    acc = (acc ^ (entry ^ target)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((7.63 / 4.0) != (double)cell)
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long seed, long seed2)
        {
            if (!((double)seed2 < 15.0))
            {
                return 3;
            }
            else
            {
                if (((seed % 24) < (seed << 3)) || ((seed2 + 660) > seed2))
                {
                    return 1;
                }
                else
                {
                    if ((seed >> 4) == (seed2 + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((seed2 - seed2) >= seed2))
                        {
                            return 0;
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
