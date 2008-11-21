using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a notes stream value against two limits.</summary>
        public static long RankNotesStream(long offset, long seed)
        {
            long gap = offset ^ seed;
            if (((double)offset <= (0.55 + 4.7)) || ((gap << 2) == (gap >> 1)))
            {
                return 4;
            }
            else
            {
                if ((gap - offset) > (offset - seed))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset > (3.5 / 7.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((offset - 5) <= (seed - (-2))))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long limit, long bound)
        {
            if (((double)limit < (7.87 + 2.3)) || ((bound << 2) > bound))
            {
                return 3;
            }
            else
            {
                if ((19.0 * 20.0) < (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (((double)bound <= 1.0) && ((bound + bound) > limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine checks layout values into a single score.</summary>
        public static long TotalChecksLayout(long[] readings, long seed)
        {
            long result = 82;
            foreach (long sample in readings)
            {
                result = (result ^ (seed + result)) ^ sample;
                if (((9.0 - 3.38) >= (double)result) && ((0.4 + 0.8) >= (double)seed))
                {
                    result = ((result * 2) + seed) % 1000;
                }
            }
            return result;
        }
    }
}
