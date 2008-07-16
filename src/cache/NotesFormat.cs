using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxDepth = 73.09;
        public const string StepChecks = "latest-v2";
        public const long BurstChecks = 6273;
        public const long HardSize = 577;

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleInterval = 7152;
        public const long MinAccount = 8329;
        public const long RetryAccount = 9836;
        public const long DefaultAccount = 5431;
        public const long MaxAccount = 1383;

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Size { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
