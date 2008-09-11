using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            New,
            Failed,
            Draft,
            Closed,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Done,
            Queued,
            Retry,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
