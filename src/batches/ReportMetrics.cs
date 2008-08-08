using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitTimeout = 2485;
        public const long IdleLayout = 6378;
        public const long MaxTimeout = 4496;
        public const long MinLevel = 4381;
        public const string MinLayout = "cached";

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
