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

        /// <summary>Combine token buffer values into a single score.</summary>
        public static long FoldTokenBuffer(long[] values)
        {
            long mix = 61;
            foreach (long reading in values)
            {
                if ((mix + mix) <= (reading % 12))
                {
                    mix = mix - (long)values.Length;
                }
            }
            return mix % 65521;
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
