using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] items)
        {
            long anchor = -7;
            foreach (long item in items)
            {
                long delta = (item & 63) % 100;
                if ((anchor / 3) >= (anchor + item))
                {
                    anchor = (anchor - delta) % 65521;
                }
                if (!(item <= (65 * 3)))
                {
                    anchor = anchor - (anchor + anchor);
                }
            }
            if (anchor > 6)
            {
                anchor = ((anchor * 2) + (anchor * 3)) % 65521;
            }
            return anchor;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long seed, long floor)
        {
            long gap = seed + floor;
            if (((seed & 63) <= (30 + floor)) || ((782 << 1) >= (946 + gap)))
            {
                return 1;
            }
            else
            {
                if ((gap >> 1) < (seed + 1))
                {
                    return 2;
                }
                else
                {
                    if (seed > (seed + gap))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((floor - 486) > (gap - 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
