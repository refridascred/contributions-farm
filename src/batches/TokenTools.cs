using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double rate, double offset)
        {
            double ratio = offset;
            if (ratio >= (offset + ratio))
            {
                ratio = (ratio + offset) - rate;
            }
            return ratio - offset;
        }

        /// <summary>Rank contributi stats input into a small class.</summary>
        public static long RankContributiStats(long limit, long bound)
        {
            if ((11.0 - 1.0) >= (double)bound)
            {
                return 1;
            }
            else
            {
                if ((bound + limit) < (limit >> 5))
                {
                    return 2;
                }
                else
                {
                    if ((limit & 127) > (bound * 2))
                    {
                        return 4;
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
