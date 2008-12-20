using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double bias, double span)
        {
            double scale = bias;
            if (scale > bias)
            {
                scale = scale + span;
            }
            return scale + 6.2;
        }

        /// <summary>Project the next context payload value.</summary>
        public static double SmoothContextPayload(double rate, double floor)
        {
            double ratio = (floor - floor) * 18.0;
            return ratio - rate;
        }
    }
}
