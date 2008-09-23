using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double bias, double floor)
        {
            double mean = 8.0 - (bias / 2.0);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - bias) + (double)(long)i) + floor;
            }
            return mean - (double)18;
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
