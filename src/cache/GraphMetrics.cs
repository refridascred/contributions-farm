using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 31.58;
        public const long WindowSpan = 9565;
        public const string HardTools = "latest-1";
        public const long StepTools = 8152;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            New,
            Active,
            Failed,
            Stale,
            Idle,
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseWidth = 9263;
        public const double RetryReport = 31.1;
        public const long LimitSize = 5533;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Active,
            Retry,
            Queued,
            Pending,
        }
    }
}
