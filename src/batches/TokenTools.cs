using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
