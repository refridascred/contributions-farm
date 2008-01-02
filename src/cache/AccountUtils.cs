using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetrySize = 1334;
        public const long BaseToken = 3967;
        public const string MinToken = "stable-edge";
        public const long SoftToken = 1195;
    }
}
