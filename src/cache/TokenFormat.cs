using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Queued,
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double bias, double floor)
        {
            double gain = floor;
            if (gain > (gain * 3.1))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - (6.8 * 16.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (bias - bias)) - (double)(long)i;
            }
            return gain - (bias * 6.3);
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double floor)
        {
            double drift = 7.98 + (floor - floor);
            if (drift > drift)
            {
                drift = drift - (drift + drift);
            }
            else
            {
                drift = drift - (floor + rate);
            }
            return drift + (rate - floor);
        }
    }
}
