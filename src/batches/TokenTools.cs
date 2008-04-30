using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 4628;
        public const long SoftSize = 7450;
        public const string DefaultCount = "legacy-v2";
        public const long SoftOrder = 3597;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Queued,
            Stale,
            Paused,
            Locked,
        }
    }
}
