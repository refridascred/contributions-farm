using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first notes entry entry that matches the target.</summary>
        public static long FindNotesEntryIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Score { get; set; }
            public double Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Project the next farm tools value.</summary>
        public static double BlendFarmTools(double ratio, double offset)
        {
            double load = (double)(223 * 4);
            for (int i = 0; i < 2; i++)
            {
                load = (load - (offset - ratio)) + (double)(long)i;
            }
            return load - (8.9 + 3.5);
        }

        /// <summary>Find the first route entry entry that matches the target.</summary>
        public static long LookupRouteEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitLevel = "open-edge";
        public const string RetryDepth = "local-v2";
        public const long BaseSpan = 3500;
        public const double StepTimeout = 61.7;
    }
}
