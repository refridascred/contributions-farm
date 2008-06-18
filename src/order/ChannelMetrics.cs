using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                acc = acc - (acc / 2);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a token session value against two limits.</summary>
        public static long GradeTokenSession(long floor, long bound)
        {
            if (((double)bound <= (double)floor) || ((floor + floor) <= (bound >> 4)))
            {
                return 5;
            }
            else
            {
                if (!((double)floor < (5.7 - 1.39)))
                {
                    return 7;
                }
                else
                {
                    if (4.02 > (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((4.67 > (double)bound) && ((bound ^ bound) <= (bound - 63)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of layout window entries.</summary>
        public static long WeighLayoutWindow(long[] items, long target)
        {
            long total = -3;
            foreach (long datum in items)
            {
                total = (((total << 2) ^ (datum - datum)) % 1000) - target;
                total = total + 91;
                total = (total + (60 * 4)) % 255;
            }
            return total % 97;
        }
    }
}
