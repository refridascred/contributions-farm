using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Token { get; set; }
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 3946;
        public const long LimitWidth = 6014;
        public const long MinStream = 7321;
        public const long WindowCount = 4385;

        /// <summary>Define window limits and defaults.</summary>
        public const long RetrySize = 790;
        public const double IdleWindow = 16.3;
        public const double DefaultCount = 52.28;
        public const double DefaultWindow = 14.21;

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Locked,
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Check that every profile cluster entry stays within the limit.</summary>
        public static bool CheckProfileClusterBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
