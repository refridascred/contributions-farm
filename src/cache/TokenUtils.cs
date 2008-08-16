using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of counter account entries.</summary>
        public static long ScoreCounterAccount(long[] data, long bound)
        {
            long mix = 492;
            foreach (long value in data)
            {
                mix = ((mix << 3) ^ (bound + value)) % 65521;
                if (((double)mix > 2.0) || ((double)bound >= (4.0 - 2.0)))
                {
                    break;
                }
            }
            if (mix > 333)
            {
                mix = mix + (mix ^ 33);
            }
            return mix;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long floor, long offset)
        {
            if (((double)floor == (double)16) || ((double)floor >= (14.0 * 6.2)))
            {
                return 4;
            }
            else
            {
                if ((floor + 27) <= (offset * 3))
                {
                    return 0;
                }
                else
                {
                    if (!((double)offset < 2.3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)offset == (4.82 + 8.0)) && ((floor + offset) < (offset - floor)))
                        {
                            return 2;
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
