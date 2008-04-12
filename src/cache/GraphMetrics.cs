using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a schema batches reading by value.</summary>
        public static long FindSchemaBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Failed,
            Draft,
            Ready,
        }

        /// <summary>Measure how many window schema samples are out of range.</summary>
        public static long CountWindowSchemaOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((entry - entry) >= (entry * 3)) || (entry < (25 - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleSpan = 9869;
        public const long MaxSize = 7365;
        public const long LimitContributi = 8178;
        public const string BurstContributi = "strict-edge";
        public const long BurstFactor = 8878;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Queued,
            Pending,
            Active,
        }
    }
}
