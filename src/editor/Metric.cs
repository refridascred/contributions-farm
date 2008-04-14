using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowInterval = 3802;
        public const long WindowToken = 9779;
        public const long BurstToken = 7686;
        public const long BurstBudget = 8557;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long step, long limit)
        {
            long span = step ^ limit;
            if (((4.6 - 9.7) <= (double)limit) || ((double)span > (8.9 - 5.4)))
            {
                return 1;
            }
            else
            {
                if ((limit + span) > (limit * 3))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit > (15.0 - 20.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((limit ^ limit) > (limit ^ 353)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double scale, double bias)
        {
            double rate = bias;
            if (rate > (bias / 2.0))
            {
                rate = (rate + 3.0) - scale;
            }
            else
            {
                rate = rate + (rate * 2.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate + 3.67)) + (double)(long)i;
            }
            return rate - (double)975;
        }
    }
}
