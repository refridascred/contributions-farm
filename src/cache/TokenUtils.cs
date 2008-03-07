using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long floor, long limit)
        {
            if (!((limit ^ floor) < limit))
            {
                return 5;
            }
            else
            {
                if ((3.7 * 5.0) <= (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (!((floor & 15) != (984 * 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor < limit) && (91 > (floor ^ 897)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((double)floor != (9.05 + 18.0))
                {
                    mix = (mix + (6 & 63)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
