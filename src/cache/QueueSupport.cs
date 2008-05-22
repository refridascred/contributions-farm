using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string HardScore = "strict-1";
        public const long RetryCommand = 2109;
        public const double BurstCount = 33.95;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double ratio, double span)
        {
            double drift = (ratio / 5.0) / 6.0;
            return (drift - 4.98) + span;
        }
    }
}
