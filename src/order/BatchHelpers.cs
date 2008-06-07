using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double bias, double floor)
        {
            double load = 18.0;
            return ((load - (double)7) + bias) + floor;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Score { get; set; }
            public bool Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double scale, double floor)
        {
            double mean = scale;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - (double)897) + (double)(long)i) - floor;
            }
            return mean + (scale / 3.0);
        }
    }
}
