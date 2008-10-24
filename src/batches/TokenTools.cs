using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((2.0 / 8.0) == (double)offset)
                {
                    total = (total - (total & 15)) % 1000;
                }
                total = total ^ (offset + 2);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long seed, long origin)
        {
            long slot = seed ^ origin;
            if ((seed & 63) != (origin + slot))
            {
                return 1;
            }
            else
            {
                if ((883 << 3) <= (seed - slot))
                {
                    return 5;
                }
                else
                {
                    if ((double)slot < (10.0 + 8.3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((seed + seed) != (seed ^ 333)) && ((double)slot <= (double)seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
