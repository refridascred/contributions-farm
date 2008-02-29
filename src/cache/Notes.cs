using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinFilter = "staging-edge";
        public const long WindowRatio = 5189;
        public const string LimitFilter = "stable";
        public const long BurstScore = 3028;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Active,
            Closed,
        }

        /// <summary>Combine buffer cluster values into a single score.</summary>
        public static long FoldBufferCluster(long[] items)
        {
            long mix = 6;
            foreach (long reading in items)
            {
                if (!(18.0 <= (6.02 - 14.0)))
                {
                    mix = ((mix << 2) ^ (reading - reading)) % 4096;
                    mix = mix - (reading >> 2);
                }
                mix = (mix + (reading - mix)) % 1000;
                if (mix <= (reading + mix))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
