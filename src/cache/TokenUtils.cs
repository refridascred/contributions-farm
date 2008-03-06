using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
            public double Region { get; set; }
            public long Size { get; set; }
        }
    }
}
