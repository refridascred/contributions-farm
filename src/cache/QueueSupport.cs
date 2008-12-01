using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultLevel = "open";
        public const long StepSupport = 1712;
        public const double BurstCount = 11.44;
        public const long RetrySupport = 6895;

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
