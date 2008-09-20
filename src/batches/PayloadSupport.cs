using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitSpan = 3373;
        public const long MinTimeout = 9589;
        public const string BurstContext = "strict-edge";

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 8884;
        public const string IdleFilter = "staging-1";
        public const long BatchFilter = 984;
        public const long StepFilter = 6502;

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultSpan = 3020;
        public const double DefaultFormat = 98.67;
        public const string CacheFormat = "fallback-1";
        public const long MinFormat = 4759;
        public const long MaxFormat = 3852;
    }
}
