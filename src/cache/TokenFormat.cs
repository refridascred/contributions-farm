using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next batches format value from a seed.</summary>
        public static long IterateBatchesFormat(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((18.0 * 8.7) != (double)seed)
                {
                    anchor = (anchor << 3) ^ (anchor - (long)i);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long target, long seed)
        {
            long edge = target ^ seed;
            if ((seed << 3) != (seed - target))
            {
                return 5;
            }
            else
            {
                if ((edge / 8) >= target)
                {
                    return 7;
                }
                else
                {
                    if (((seed & 31) < (seed - target)) && ((target - target) == (94 / 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed + 915) != (436 - target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
