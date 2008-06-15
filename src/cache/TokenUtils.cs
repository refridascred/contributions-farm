using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long target, long floor)
        {
            long span = target ^ floor;
            if ((target / 2) <= target)
            {
                return 5;
            }
            else
            {
                if ((double)span > (4.72 - 3.51))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double gain, double span)
        {
            double drift = gain;
            if (drift > drift)
            {
                drift = drift - gain;
            }
            else
            {
                drift = drift - (4.1 + drift);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (2.41 - drift)) + (double)(long)i;
            }
            return drift + (span * 3.0);
        }
    }
}
