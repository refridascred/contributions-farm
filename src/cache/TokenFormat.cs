using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitInterval = 795;
        public const string LimitRecord = "strict-edge";
        public const long BurstRecord = 8547;
        public const long LimitRatio = 943;

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double ratio, double bias)
        {
            double drift = ratio;
            if (drift > (double)35)
            {
                drift = (drift - drift) + bias;
            }
            else
            {
                drift = drift + (double)95;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + 8.09) - (double)(long)i;
            }
            return drift + ratio;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
