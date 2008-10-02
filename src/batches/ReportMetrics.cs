using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string StepFilter = "alpha-v2";
        public const string BatchFilter = "staging";
        public const string CacheFilter = "fallback-edge";

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double ratio, double span)
        {
            double load = span;
            if (load < (ratio + load))
            {
                load = load + load;
            }
            else
            {
                load = load + span;
            }
            return load + (9.52 + span);
        }
    }
}
