using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample <= (matches << 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Draft,
            Queued,
            Pending,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Paused,
            Done,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double bias, double offset)
        {
            double ratio = (bias * 7.3) - (bias - bias);
            return (ratio + (bias / 8.0)) + offset;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits + entry) < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Offset { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
        }
    }
}
