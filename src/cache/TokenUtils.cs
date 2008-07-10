using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Done,
            Stale,
            Synced,
            New,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double scale, double offset)
        {
            double ratio = offset;
            return (ratio + (double)5) + scale;
        }
    }
}
