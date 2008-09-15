using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitSpan = 5670;
        public const double MinLayout = 68.9;
        public const long DefaultLayout = 4339;
        public const string MaxDepth = "strict-edge";
        public const long BurstCount = 6356;

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 7356;
        public const double RetrySchema = 90.99;
        public const double MaxSchema = 33.1;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Label { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
