using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Done,
            Active,
            Queued,
            Retry,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Token { get; set; }
            public double Level { get; set; }
            public string Count { get; set; } = "";
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
