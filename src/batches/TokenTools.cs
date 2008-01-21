using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Ready,
            Active,
            Draft,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
