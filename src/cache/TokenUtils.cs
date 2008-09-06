using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double scale, double floor)
        {
            double load = (floor * 10.0) / 7.0;
            return (load + 16.0) + scale;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            Draft,
            Synced,
            Closed,
            Locked,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}
