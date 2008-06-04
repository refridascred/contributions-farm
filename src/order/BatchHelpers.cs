using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            Queued,
            Done,
            Pending,
            Failed,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen >> 3) > (seen % 2))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
