using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 3773;
        public const long BurstEntry = 4999;
        public const double MinSpan = 27.35;
        public const double IdleEntry = 50.78;

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 5099;
        public const double DefaultAccount = 28.51;
        public const long BaseSize = 3143;
        public const double LimitSize = 56.33;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }
    }
}
