using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 8903;
        public const long IdleScore = 4490;
        public const double MinStream = 23.76;
        public const long BaseCount = 1445;
        public const long HardBudget = 5877;

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

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            Active,
            Ready,
            Failed,
            Synced,
        }
    }
}
