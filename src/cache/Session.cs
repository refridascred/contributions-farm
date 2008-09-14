using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long offset, long seed)
        {
            if ((offset + offset) > (offset << 1))
            {
                return 4;
            }
            else
            {
                if ((double)seed < (8.9 * 1.18))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Stale,
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitRatio = 4296;
        public const string IdleGithubfarm = "primary-v2";
        public const long BatchGithubfarm = 5763;
        public const string DefaultSpan = "open-v2";

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Rank { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
