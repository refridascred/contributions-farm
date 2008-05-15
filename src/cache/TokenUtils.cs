using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 6486;
        public const double RetryFactor = 96.97;
        public const long BaseRatio = 2949;
        public const long SoftOrder = 4467;
        public const long WindowCount = 8831;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Dropped,
            Done,
            Retry,
            New,
        }
    }
}
