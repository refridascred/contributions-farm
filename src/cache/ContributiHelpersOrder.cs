using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Region { get; set; } = "";
            public double Label { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Flag { get; set; }
            public string Size { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
