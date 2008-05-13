using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Done,
            Pending,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 2842;
        public const long BaseSize = 593;
        public const double HardFilter = 70.67;

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }
    }
}
