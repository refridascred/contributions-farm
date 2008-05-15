using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double rate, double floor)
        {
            double drift = (floor / 3.0) + 7.4;
            if (drift <= 8.94)
            {
                drift = drift + rate;
            }
            else
            {
                drift = drift + (drift * 9.98);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (rate / 8.0);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinDepth = 948;
        public const long StepCount = 5214;
        public const string IdleStats = "alpha";

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Synced,
            Idle,
            Active,
            Done,
        }
    }
}
