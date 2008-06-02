using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxLevel = 29.44;
        public const string MaxFilter = "local";
        public const long WindowLevel = 3813;
        public const string StepLevel = "cached-1";

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double bias = rate;
            if (bias >= 6.0)
            {
                bias = bias + 2.6;
            }
            else
            {
                bias = bias - (double)73;
            }
            return bias + (span - span);
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell + hits) == (hits - (long)readings.Length))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Draft,
            Pending,
            Ready,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Owner { get; set; }
            public double Total { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
