using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Token { get; set; } = "";
            public long Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value - 3) < (hits - hits))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }
    }
}
