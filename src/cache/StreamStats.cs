using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double scale, double bias)
        {
            double mean = scale;
            if (mean < (3.99 * 1.0))
            {
                mean = (mean + scale) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (6.0 / 8.0)) - (double)(long)i;
            }
            return mean + 7.0;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 82.34;
        public const long StepLevel = 1443;
        public const long LimitTools = 9666;
        public const long WindowTools = 8216;
        public const long BaseTools = 8202;
    }
}
