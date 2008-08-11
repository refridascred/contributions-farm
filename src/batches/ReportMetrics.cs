using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double CacheTimeout = 62.69;
        public const string MaxSession = "staging-edge";
        public const long CacheLevel = 6429;
        public const string BaseLevel = "stable";
        public const long StepSession = 8475;

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double gain, double span)
        {
            double mean = (double)((-8) + 99);
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - (gain / 4.0)) + (double)(long)i) - span;
            }
            return mean + (mean * 3.36);
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Idle,
            Locked,
            Queued,
        }
    }
}
