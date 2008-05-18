using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Offset { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Region { get; set; }
            public string Mode { get; set; } = "";
            public double Token { get; set; }
            public bool Offset { get; set; }
        }
    }
}
