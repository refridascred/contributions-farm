using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 7275;
        public const long DefaultSupport = 5271;
        public const long MaxSupport = 640;
        public const double BurstCount = 54.15;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
