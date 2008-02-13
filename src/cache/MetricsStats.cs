using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate schema metric readings against a bound.</summary>
        public static bool VerifySchemaMetricBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 6142;
        public const long DefaultChecks = 6022;
        public const string RetryWidth = "standard-edge";
        public const double BurstBudget = 40.85;
        public const long BurstSpan = 8662;

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 9299;
        public const double DefaultTools = 67.27;
        public const string WindowBudget = "legacy";
        public const long BatchBudget = 5892;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double bias, double bias2)
        {
            double load = bias;
            if (load >= (double)1)
            {
                load = load + (bias2 - load);
            }
            else
            {
                load = load - (19.0 * 9.16);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (bias + bias)) + (double)(long)i;
            }
            return load - (bias2 * 8.33);
        }
    }
}
