using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double gain, double floor)
        {
            double weight = (floor - gain) + gain;
            return weight + (13.0 * 9.85);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "strict-1";
        public const string SoftMetrics = "strict-v2";
        public const long LimitBudget = 8025;
        public const double BaseScore = 46.14;
        public const long CacheRatio = 9686;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
