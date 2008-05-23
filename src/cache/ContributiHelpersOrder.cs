using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] readings)
        {
            long score = 551;
            foreach (long cell in readings)
            {
                score = score + cell;
                score = (score ^ score) % 255;
                score = score - (209 + cell);
            }
            if (score > 2)
            {
                score = score + (score / 3);
            }
            return score;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long bound, long bound2)
        {
            if ((bound + bound) < (bound << 2))
            {
                return 8;
            }
            else
            {
                if (!(bound > (bound >> 2)))
                {
                    return 6;
                }
                else
                {
                    if (((bound2 % 8) == (bound2 + bound)) || ((bound >> 3) > (bound + bound2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound2 <= (98 + bound2)) || ((bound2 ^ bound) != (bound * 4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double bias2 = (floor * 0.5) * 3.69;
            return (bias2 - (double)655) + bias;
        }
    }
}
