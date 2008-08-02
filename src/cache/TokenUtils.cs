using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long offset, long limit)
        {
            if ((limit + offset) >= offset)
            {
                return 0;
            }
            else
            {
                if ((offset - offset) >= (offset * 2))
                {
                    return 2;
                }
                else
                {
                    if ((limit + limit) == (limit << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit != (3.22 * 0.3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
