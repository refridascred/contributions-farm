using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] series, long target)
        {
            long score = 4;
            foreach (long value in series)
            {
                if (target < (value + 170))
                {
                    score = (score + (target + (-97))) % 97;
                }
                else
                {
                    score = (score - (value >> 5)) % 255;
                }
            }
            if (score > 56)
            {
                score = (score * 2) + (target * 3);
            }
            return score;
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
