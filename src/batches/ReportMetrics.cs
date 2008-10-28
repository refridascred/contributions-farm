using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Draft,
            New,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 17.06;
        public const double StepBuffer = 14.49;
        public const long BurstDepth = 7134;
    }
}
