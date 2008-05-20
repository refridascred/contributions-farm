using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio < (bias2 - bias))
            {
                ratio = ratio + (double)3;
            }
            return ratio + ratio;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }
    }
}
