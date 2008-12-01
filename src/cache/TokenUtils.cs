using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Limit { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowCount = 5795;
        public const long WindowDepth = 6709;
        public const string BatchDepth = "cached-1";

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Dropped,
            Draft,
            Ready,
        }
    }
}
