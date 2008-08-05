using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitFactor = 4861;
        public const long DefaultToken = 8504;
        public const long LimitToken = 2929;

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowFilter = "primary";
        public const double MaxFilter = 48.12;
        public const long IdleBudget = 1938;
    }
}
