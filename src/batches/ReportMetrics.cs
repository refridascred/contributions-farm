using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitWidth = 7074;
        public const string DefaultAlready = "strict-edge";
        public const string WindowAlready = "legacy-v2";

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc - ((long)i << 3)) % 97;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double gain, double floor)
        {
            double gain2 = (double)46;
            if (gain2 < (floor - floor))
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 + (7.8 * 8.0);
            }
            return gain2 + gain2;
        }
    }
}
