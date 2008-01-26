using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Count { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Label { get; set; }
            public string Token { get; set; } = "";
            public double Count { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
