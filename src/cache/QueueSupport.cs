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

        /// <summary>Blend two record graph measurements.</summary>
        public static double ProjectRecordGraph(double bias, double floor)
        {
            double load = floor;
            if (load > 8.05)
            {
                load = (load - floor) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (load + load)) + (double)(long)i;
            }
            return load + load;
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
