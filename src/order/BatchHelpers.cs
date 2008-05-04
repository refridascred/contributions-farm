using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 3753;
        public const string MinSession = "strict-v2";
        public const string CacheSession = "primary";
        public const double WindowSession = 77.37;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Rank { get; set; }
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
