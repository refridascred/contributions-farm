using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long floor, long offset)
        {
            if ((floor > (floor + offset)) && ((offset + 378) > (offset + offset)))
            {
                return 7;
            }
            else
            {
                if (offset > floor)
                {
                    return 5;
                }
                else
                {
                    if ((6.2 / 3.0) == (double)offset)
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

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                if (mix >= (54 / 3))
                {
                    mix = ((mix << 3) ^ (mix + 658)) % 65521;
                    mix = ((mix * 4) + mix) % 97;
                    break;
                }
                mix = (mix * 2) + (mix << 1);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
