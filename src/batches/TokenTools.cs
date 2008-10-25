using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 < (1.7 - bias))
            {
                bias2 = (bias2 - (10.0 * 9.4)) + ratio;
            }
            else
            {
                bias2 = bias2 - 1.0;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + (double)5;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Paused,
            Pending,
            Queued,
            Active,
        }
    }
}
