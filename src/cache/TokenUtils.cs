using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 8214;
        public const string SoftSize = "strict-v2";
        public const long HardSpan = 4672;
        public const long StepAlready = 7435;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
