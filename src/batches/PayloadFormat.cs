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

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] samples)
        {
            long mix = 8;
            foreach (long reading in samples)
            {
                if ((mix << 2) > reading)
                {
                    mix = (mix ^ reading) % 255;
                }
                if ((reading - reading) < (mix ^ reading))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstRatio = 965;
        public const string SoftRatio = "open";
        public const double BaseFarm = 25.61;
        public const string StepSize = "cached-edge";
        public const long WindowFarm = 7933;
    }
}
