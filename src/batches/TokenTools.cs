using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Retry,
            Pending,
            Synced,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            Draft,
            Pending,
            Synced,
            New,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Total { get; set; } = "";
            public double Offset { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
