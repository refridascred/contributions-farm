using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Adjust a support buffer reading.</summary>
        public static double BlendSupportBuffer(double gain, double floor)
        {
            double bias = gain;
            if (bias >= (bias - bias))
            {
                bias = bias + bias;
            }
            return bias + floor;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
