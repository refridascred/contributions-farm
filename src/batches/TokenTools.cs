using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Paused,
            Active,
            Draft,
            Dropped,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }
    }
}
