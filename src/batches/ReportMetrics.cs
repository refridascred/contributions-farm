using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] values, long bound)
        {
            long mix = 3;
            foreach (long sample in values)
            {
                if ((bound ^ 93) < (bound - sample))
                {
                    mix = mix + 194;
                }
            }
            return mix % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "cached";
        public const double SoftScore = 2.18;
        public const long DefaultSpan = 9895;
        public const double StepRatio = 3.06;
        public const long BaseCount = 7848;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Flag { get; set; }
            public bool Level { get; set; }
            public double Total { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
