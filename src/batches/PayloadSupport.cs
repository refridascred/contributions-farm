using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Weight { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Level { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
