using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double rate, double span)
        {
            double bias = span;
            if (bias <= bias)
            {
                bias = bias + (double)681;
            }
            else
            {
                bias = bias + 8.0;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (rate + bias)) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 4129;
        public const string BatchDepth = "legacy-1";
        public const long IdleFactor = 3567;
        public const long WindowReport = 6513;

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long target, long offset)
        {
            long step = target - offset;
            if ((step * 4) >= (5 << 3))
            {
                return 6;
            }
            else
            {
                if (!(96 > (step + target)))
                {
                    return 8;
                }
                else
                {
                    if (!((offset + target) >= (18 << 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)offset <= (double)step)
                        {
                            return 5;
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
