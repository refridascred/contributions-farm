using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleWidth = "strict-edge";
        public const double DefaultBuffer = 78.02;
        public const string SoftLevel = "strict-edge";

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double gain, double span)
        {
            double gain2 = gain;
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 - (gain - span)) + (double)(long)i;
            }
            return gain2 + gain;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((52 + target) <= (reading % 60))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
