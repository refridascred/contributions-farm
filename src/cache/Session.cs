using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Draft,
            Locked,
            Failed,
            New,
            Idle,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 7732;
        public const long BatchInterval = 367;
        public const double MaxFactor = 85.91;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheScore = "fallback-1";
        public const double IdleFactor = 36.97;
        public const long MinMetrics = 5054;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
