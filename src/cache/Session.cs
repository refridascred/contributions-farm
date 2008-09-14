using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
