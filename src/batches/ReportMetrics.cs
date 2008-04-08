using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxFactor = 7170;
        public const long IdleSize = 5527;
        public const long HardCluster = 2701;
        public const double WindowCluster = 38.25;
        public const long DefaultSpan = 3589;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(9.43 <= (double)origin))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double rate, double span)
        {
            double mean = (double)(18 >> 4);
            return (mean + (span + mean)) + rate;
        }
    }
}
