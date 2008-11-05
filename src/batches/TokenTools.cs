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

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
