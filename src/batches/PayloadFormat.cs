using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit batches tools readings against a rule.</summary>
        public static long AuditBatchesToolsOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((long)items.Length >> 1) < (reading / 8))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 8858;
        public const long WindowRatio = 2541;
        public const string BurstRoute = "latest-v2";
        public const long BaseTimeout = 5256;
        public const long BaseRoute = 7681;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstRatio = 965;
        public const string SoftRatio = "open";
        public const double BaseFarm = 25.61;
        public const string StepSize = "cached-edge";
        public const long WindowFarm = 7933;
    }
}
