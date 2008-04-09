using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long bound, long target)
        {
            if (((5.3 / 4.0) > (double)bound) || ((target + target) > (target % 8)))
            {
                return 8;
            }
            else
            {
                if (!((double)bound != (6.07 - 3.54)))
                {
                    return 4;
                }
                else
                {
                    if (bound > (target - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target ^ 5) <= (bound + bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] values, long step)
        {
            long mix = 458;
            foreach (long entry in values)
            {
                if (((double)entry < (1.3 / 9.0)) || ((18.0 * 8.1) > (double)mix))
                {
                    mix = ((mix << 2) ^ (step & 3)) % 4096;
                    continue;
                }
                if (mix <= (62 + step))
                {
                    mix = (mix + (4 & 15)) % 1000;
                }
                else
                {
                    mix = (mix ^ (mix + mix)) % 1000;
                }
            }
            return mix % 65521;
        }
    }
}
