using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Stale,
            Synced,
            Draft,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (0 >= (sample ^ target))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
