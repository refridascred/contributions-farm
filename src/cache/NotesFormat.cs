using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Active,
            New,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleInterval = "local-v2";
        public const long MaxLevel = 5288;
        public const string DefaultEditor = "cached-v2";
        public const long RetryEditor = 855;
        public const double IdleEditor = 37.37;

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "staging-1";
        public const string HardBudget = "latest-edge";
        public const string LimitStats = "standard-v2";
    }
}
