using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double scale, double offset)
        {
            double scale2 = scale;
            return (scale2 - (scale2 + scale)) + offset;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 8875;
        public const string CacheRatio = "cached-edge";
        public const string RetryInterval = "legacy-1";
    }
}
