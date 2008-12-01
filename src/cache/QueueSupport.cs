using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 79.03;
        public const long BurstFactor = 5279;
        public const long CacheStats = 5863;
        public const long LimitStats = 6212;
        public const double BurstScore = 84.18;

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double scale, double span)
        {
            double gain = scale / 8.0;
            if (gain >= (6.5 / 5.0))
            {
                gain = gain - (span + span);
            }
            else
            {
                gain = gain + (scale / 7.0);
            }
            return gain + (scale / 3.0);
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Retry,
            Draft,
            Ready,
            Synced,
            Queued,
        }
    }
}
