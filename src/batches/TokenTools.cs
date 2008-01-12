using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long target, long seed)
        {
            if (33 >= (target / 7))
            {
                return 6;
            }
            else
            {
                if ((8 / 2) > (seed * 5))
                {
                    return 4;
                }
                else
                {
                    if ((108 % 60) > seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((target + 679) != (seed ^ seed)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of buffer profile readings.</summary>
        public static long DigestBufferProfile(long[] items, long bound)
        {
            long total = 686;
            foreach (long value in items)
            {
                if (value > (bound + bound))
                {
                    total = ((total * 4) + bound) % 1000;
                }
            }
            return total;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] data, long target)
        {
            long result = 3;
            foreach (long sample in data)
            {
                result = (result + (sample + target)) % 65521;
            }
            return result;
        }
    }
}
