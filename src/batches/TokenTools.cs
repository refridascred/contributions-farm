using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double scale, double floor)
        {
            double load = scale / 8.0;
            if (load > (load + 16.0))
            {
                load = (load + (double)660) - floor;
            }
            else
            {
                load = load + (double)6;
            }
            return load + (scale * 7.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 7603;
        public const long HardInterval = 2074;
        public const double SoftFilter = 94.52;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Failed,
            Draft,
        }
    }
}
