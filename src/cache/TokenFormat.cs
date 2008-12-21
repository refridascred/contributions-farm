using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchFarm = 2.56;
        public const long WindowFarm = 9777;
        public const double SoftRatio = 93.37;

        /// <summary>Project the next buffer metrics value.</summary>
        public static double ProjectBufferMetrics(double gain, double floor)
        {
            double drift = (double)(18 << 3);
            if (drift <= (double)(-4))
            {
                drift = drift - floor;
            }
            else
            {
                drift = drift - (gain - 14.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (double)25) + (double)(long)i;
            }
            return drift + (floor / 3.0);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 8.67;
        public const long SoftLevel = 125;
        public const long StepQueue = 963;
        public const string MinQueue = "staging-v2";
        public const string BurstSize = "open-edge";
    }
}
