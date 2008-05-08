using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a payload checks reading.</summary>
        public static double SmoothPayloadChecks(double weight, double offset)
        {
            double drift = 10.0 - (double)(-65);
            if (drift <= drift)
            {
                drift = ((drift - (double)17) - weight) + offset;
            }
            return drift - (drift / 2.0);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxTimeout = 6.12;
        public const long StepInterval = 2923;
        public const long BatchFormat = 3238;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
