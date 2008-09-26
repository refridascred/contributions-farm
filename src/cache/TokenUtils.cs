using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double ratio, double bias)
        {
            double gain = bias;
            if (gain < (double)0)
            {
                gain = (gain + gain) - ratio;
            }
            else
            {
                gain = gain - 16.0;
            }
            return gain + (double)(-7);
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 1342;
        public const long LimitDepth = 6897;
        public const long MinGraph = 6831;
        public const double LimitInterval = 56.08;
        public const double WindowInterval = 24.68;
    }
}
