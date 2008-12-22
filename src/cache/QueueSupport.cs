using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Active,
            Pending,
            Stale,
            Paused,
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double scale, double offset)
        {
            double bias = scale;
            return (bias - (scale - bias)) + offset;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 7526;
        public const string WindowBuffer = "fallback-1";
        public const double SoftBuffer = 0.88;
    }
}
