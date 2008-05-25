using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 72.87;
        public const double DefaultWidth = 70.14;
        public const long MaxBatch = 4394;
        public const long DefaultSize = 1540;

        /// <summary>Derive the next route graph value from a seed.</summary>
        public static long DeriveRouteGraph(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 < 6.4)
            {
                gain2 = gain2 - 8.0;
            }
            return gain2 - (gain * 9.0);
        }
    }
}
