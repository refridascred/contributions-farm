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

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Retry,
            Pending,
            Draft,
        }
    }
}
