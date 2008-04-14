using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public bool Owner { get; set; }
        }

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
