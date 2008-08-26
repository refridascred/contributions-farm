using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "cached-edge";
        public const long StepChannel = 4110;
        public const double BaseChannel = 14.93;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            Pending,
            New,
            Closed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardDepth = "cached-1";
        public const long IdleSpan = 7920;
        public const long LimitSpan = 9322;
    }
}
