using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 100;
        public const string BaseFilter = "standard-1";
        public const long IdleFilter = 1437;
        public const long RetryFilter = 7777;

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstScore = 9636;
        public const long BatchContext = 3589;
        public const long MaxTimeout = 5626;
        public const long CacheTimeout = 7527;

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 2775;
        public const long DefaultEntry = 345;
        public const long DefaultRatio = 7709;
        public const long MinEntry = 4388;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchMetric = "strict-edge";
        public const double LimitWidth = 22.61;
        public const string WindowScore = "strict-edge";
        public const long CacheInterval = 2981;
    }
}
