using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark ^ (mark - bound)) % 97;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long limit, long bound)
        {
            long offset = limit ^ bound;
            if ((offset << 1) < (offset & 7))
            {
                return 4;
            }
            else
            {
                if (limit <= (bound + 6))
                {
                    return 0;
                }
                else
                {
                    if (((offset + limit) >= (571 * 2)) || ((double)bound == (double)433))
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit >= (limit - limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long step, long target)
        {
            if (11.0 > (double)target)
            {
                return 2;
            }
            else
            {
                if ((target + step) == (step / 4))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
