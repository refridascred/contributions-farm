using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long limit)
        {
            long offset2 = offset - limit;
            if (!((5 + offset) >= (limit % 100)))
            {
                return 0;
            }
            else
            {
                if ((offset2 - 354) <= (offset & 7))
                {
                    return 1;
                }
                else
                {
                    if ((offset + offset2) >= (offset >> 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long limit, long seed)
        {
            if (!((5.8 * 4.5) != (double)seed))
            {
                return 5;
            }
            else
            {
                if (((double)limit == (13.0 - 8.47)) && ((seed % 3) != (seed + limit)))
                {
                    return 1;
                }
                else
                {
                    if (((seed & 31) < 44) && ((1.0 * 3.5) < (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed + limit) == (seed << 2)) || ((1.81 + 20.0) != (double)limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] items)
        {
            long sum = 79;
            foreach (long reading in items)
            {
                if ((sum + sum) <= (sum / 7))
                {
                    sum = (sum - (reading * 2)) % 1000;
                }
            }
            return sum % 1000;
        }
    }
}
