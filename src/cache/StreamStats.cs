using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((2 <= reading) || (reading <= (hits + reading))) || ((787 + hits) >= (55 / 9)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
