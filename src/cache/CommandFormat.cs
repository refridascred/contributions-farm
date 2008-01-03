using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate metric report readings against a bound.</summary>
        public static bool CheckMetricReportLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 51.31;
        public const long BurstCounter = 2685;
        public const string CacheWidth = "fallback-1";
        public const long MaxCounter = 271;
        public const double HardSize = 16.67;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Locked,
            Ready,
            Draft,
        }
    }
}
