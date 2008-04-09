using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Count { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Region { get; set; }
            public bool Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
