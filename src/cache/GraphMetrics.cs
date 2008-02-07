using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Active,
            Paused,
            Dropped,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheCount = 2989;
        public const string WindowRatio = "stable-1";
        public const long RetryAlready = 4275;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Size { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "standard";
        public const double BaseSchema = 20.74;
        public const long SoftSchema = 4104;
        public const long BaseLevel = 3129;
    }
}
