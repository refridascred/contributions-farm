using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MaxSpan = 386;
        public const string HardInterval = "strict-v2";
        public const double HardLevel = 41.01;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Dropped,
            Draft,
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
