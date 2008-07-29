using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Locked,
            New,
            Failed,
            Active,
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Score { get; set; }
            public long Total { get; set; }
        }
    }
}
