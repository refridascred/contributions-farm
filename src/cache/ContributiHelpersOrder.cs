using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
