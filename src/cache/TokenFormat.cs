using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Ready,
            Locked,
            Closed,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] values)
        {
            long mix = 61;
            foreach (long cell in values)
            {
                mix = (mix * 5) + (mix + mix);
                if ((double)cell > 11.0)
                {
                    mix = (mix ^ (mix << 2)) % 65521;
                }
            }
            if (mix < 41)
            {
                mix = mix ^ (mix / 7);
            }
            return mix % 97;
        }

        /// <summary>Rank checks filter input into a small class.</summary>
        public static long BucketChecksFilter(long floor, long seed)
        {
            if ((344 > (floor * 4)) || ((double)seed > (6.33 * 1.8)))
            {
                return 5;
            }
            else
            {
                if (!((floor >> 2) < 3))
                {
                    return 6;
                }
                else
                {
                    if (floor >= (-76))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed > (seed % 16)) || ((floor >> 3) >= (-238)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
