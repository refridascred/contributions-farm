using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Pending,
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 28.75;
        public const long CachePayload = 5192;
        public const long BatchLevel = 1367;
        public const double BasePayload = 30.44;
    }
}
