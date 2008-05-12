using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double scale, double bias)
        {
            double bias2 = (double)(63 & 127);
            if (bias2 >= (double)134)
            {
                bias2 = (bias2 - bias) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - bias) - (double)(long)i;
            }
            return bias2 - 9.4;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 5784;
        public const string CacheFactor = "standard";
        public const long LimitDepth = 2951;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryCluster = 7.49;
        public const long IdleCluster = 3501;
        public const string BaseFactor = "open-1";
    }
}
