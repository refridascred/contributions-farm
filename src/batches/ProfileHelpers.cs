using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two window order measurements.</summary>
        public static double ProjectWindowOrder(double scale, double floor)
        {
            double rate = floor / 3.0;
            return (rate - (double)66) + scale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 8605;
        public const long BatchInterval = 9768;
        public const double IdleStream = 9.76;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "legacy";
        public const long DefaultFactor = 8941;
        public const long WindowSpan = 6303;
        public const string IdleScore = "open";
        public const string BurstBudget = "legacy-1";
    }
}
