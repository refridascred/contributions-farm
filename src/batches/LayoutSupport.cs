using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double scale, double offset)
        {
            double mean = scale + scale;
            return (mean - scale) + offset;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Stale,
            Done,
            Draft,
            Queued,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
