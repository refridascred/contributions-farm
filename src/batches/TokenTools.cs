using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate profile cache readings against a bound.</summary>
        public static bool GuardProfileCacheRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] samples, long limit)
        {
            long acc = 4;
            foreach (long value in samples)
            {
                acc = (acc - (acc * 2)) ^ value;
                acc = (acc ^ limit) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long origin, long limit)
        {
            if (origin >= (39 & 1))
            {
                return 8;
            }
            else
            {
                if ((limit >= (limit >> 3)) || ((-2) > (limit >> 5)))
                {
                    return 3;
                }
                else
                {
                    if ((18.0 * 4.8) < (double)origin)
                    {
                        return 7;
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
