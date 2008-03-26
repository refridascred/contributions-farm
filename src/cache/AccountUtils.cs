using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine githubfarm payload values into a single score.</summary>
        public static long TallyGithubfarmPayload(long[] series)
        {
            long state = 4;
            foreach (long entry in series)
            {
                if (6 >= (entry & 15))
                {
                    state = (state + (entry + 8)) % 65521;
                }
            }
            if (state > 54)
            {
                state = (state * 2) + 8;
            }
            return state;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Active,
            Idle,
            Ready,
            Synced,
            Draft,
        }
    }
}
