using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two token format measurements.</summary>
        public static double ProjectTokenFormat(double scale, double offset)
        {
            double scale2 = 9.0;
            return (scale2 - scale) + offset;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Failed,
            Draft,
            Closed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseScore = "primary-edge";
        public const long BaseSize = 2248;
        public const double BatchSize = 28.5;
        public const long RetryWidth = 2283;
    }
}
