using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long offset, long target)
        {
            long lane = offset + target;
            if ((lane >= (target / 9)) || ((double)lane <= (3.9 - 20.0)))
            {
                return 4;
            }
            else
            {
                if (!((-13) <= lane))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long anchor = 469;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = ((anchor ^ (cell % 60)) % 101) + (long)i;
                }
                anchor = anchor + (long)levels.Length;
                anchor = ((anchor << 3) ^ (anchor * 3)) % 101;
                if ((anchor ^ cell) > cell)
                {
                    break;
                }
            }
            if (anchor < 21)
            {
                anchor = (anchor ^ anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long seed, long seed2)
        {
            long cur = seed + seed2;
            if ((seed - cur) != (cur ^ 9))
            {
                return 4;
            }
            else
            {
                if (((cur / 2) < seed2) && ((seed % 8) > (seed * 5)))
                {
                    return 1;
                }
                else
                {
                    if (cur <= 514)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((87 + 96) != (seed - seed2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
