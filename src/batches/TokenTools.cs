using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitSpan = 4877;
        public const long BaseFactor = 8436;
        public const double SoftContext = 71.54;
        public const long HardContext = 2967;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Done,
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
