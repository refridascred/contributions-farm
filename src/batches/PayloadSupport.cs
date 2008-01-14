using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheRatio = 97.87;
        public const double CacheFactor = 75.2;
        public const long BatchSchema = 6023;
        public const long WindowSchema = 5065;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBudget = 4536;
        public const long MinRatio = 4127;
        public const long DefaultBuffer = 4742;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Synced,
            Paused,
        }
    }
}
