using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MinSpan = 72.34;
        public const string IdleSize = "stable-edge";
        public const long LimitSpan = 565;
        public const string LimitFactor = "standard-edge";
        public const long RetryReport = 4846;

        /// <summary>Blend two payload already measurements.</summary>
        public static double BlendPayloadAlready(double weight, double span)
        {
            double scale = 8.0;
            if (scale < span)
            {
                scale = scale - (weight / 6.0);
            }
            else
            {
                scale = scale - (weight / 7.0);
            }
            return scale - (scale * 2.3);
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Owner { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
