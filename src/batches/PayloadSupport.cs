using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftScore = 9.19;
        public const long CacheDepth = 9672;
        public const double LimitMetric = 91.98;

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseSize = 11.4;
        public const double SoftNotes = 18.1;
        public const string BaseNotes = "latest-edge";
        public const string WindowNotes = "alpha-v2";
        public const string CacheNotes = "standard";

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 85.12;
        public const string IdleBatches = "primary-1";
        public const long LimitBatches = 1167;
        public const long MaxCount = 9339;
        public const double SoftSize = 45.83;
    }
}
