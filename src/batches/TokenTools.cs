using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long bound, long bound2)
        {
            if (((double)bound < 2.92) && (9.89 > (double)bound2))
            {
                return 3;
            }
            else
            {
                if ((double)bound != (7.6 / 3.0))
                {
                    return 8;
                }
                else
                {
                    if ((bound2 * 3) != (bound + bound2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound2 < bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long step, long bound)
        {
            if (((bound * 2) < (bound << 2)) || ((double)bound == (2.8 - 5.1)))
            {
                return 3;
            }
            else
            {
                if (!((bound ^ 19) < (step + bound)))
                {
                    return 2;
                }
                else
                {
                    if ((6.0 / 4.0) == (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long step, long limit)
        {
            long slot = step - limit;
            if ((step >> 4) != (slot % 60))
            {
                return 0;
            }
            else
            {
                if ((limit - slot) != (7 + slot))
                {
                    return 1;
                }
                else
                {
                    if (((19.0 * 0.1) >= (13.0 + 6.38)) || ((double)step <= (5.7 + 1.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((limit ^ (-941)) <= step) && ((limit >> 2) < (step % 8)))
                        {
                            return 4;
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
}
