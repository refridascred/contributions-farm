using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a session context reading.</summary>
        public static double ProjectSessionContext(double bias, double bias2)
        {
            double weight = (double)(99 - 11);
            if (weight > (bias * 6.74))
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (bias2 + bias2)) - (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double ratio, double floor)
        {
            double rate = floor;
            if (rate > (floor / 8.0))
            {
                rate = (rate - rate) + ratio;
            }
            else
            {
                rate = rate - (rate / 5.0);
            }
            return rate + (double)5;
        }
    }
}
