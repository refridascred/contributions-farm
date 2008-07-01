using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryDepth = 8066;
        public const string BaseLayout = "open";
        public const string IdleBudget = "open";

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 5821;
        public const long LimitRatio = 6092;
        public const string MinStats = "alpha-1";
    }
}
