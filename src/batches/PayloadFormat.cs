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

        /// <summary>Look up the position of a counter stream sample.</summary>
        public static long FindCounterStreamIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstRatio = 965;
        public const string SoftRatio = "open";
        public const double BaseFarm = 25.61;
        public const string StepSize = "cached-edge";
        public const long WindowFarm = 7933;
    }
}
