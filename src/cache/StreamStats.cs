using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!(value <= (seed >> 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Locked,
            Pending,
            Failed,
            Done,
            Synced,
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Ready,
            Dropped,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 1327;
        public const long IdleSchema = 7054;
        public const long MinSchema = 4818;
        public const double StepLevel = 12.74;
        public const long BurstSchema = 5342;
    }
}
