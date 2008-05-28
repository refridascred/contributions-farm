using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 6942;
        public const long BurstCache = 2115;
        public const long WindowCache = 2907;
        public const long BurstCount = 3652;
        public const long LimitCache = 4061;

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 5504;
        public const long MinAlready = 1282;
        public const long LimitRatio = 6025;
        public const long LimitFactor = 2219;
        public const long BaseAlready = 722;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }
    }
}
