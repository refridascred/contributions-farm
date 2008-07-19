using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Ready,
            Draft,
            Closed,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double gain, double bias)
        {
            double ratio = 7.05;
            if (ratio < (ratio / 3.0))
            {
                ratio = (ratio + gain) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - (double)7;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 415;
        public const long BurstBudget = 4848;
        public const long DefaultCluster = 3191;
    }
}
