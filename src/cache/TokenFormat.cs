using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 >= (double)21)
            {
                rate2 = (rate2 - rate2) + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + 4.0) - (double)(long)i;
            }
            return rate2 - 13.0;
        }

        /// <summary>Find the first stats metrics entry that matches the target.</summary>
        public static long SeekStatsMetricsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next context payload value.</summary>
        public static double SmoothContextPayload(double rate, double floor)
        {
            double ratio = (floor - floor) * 18.0;
            return ratio - rate;
        }
    }
}
