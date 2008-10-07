using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinDepth = 2780;
        public const string CacheTimeout = "alpha-v2";
        public const double SoftFilter = 26.22;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the notes payload entries that pass the check.</summary>
        public static long AuditNotesPayloadMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((-35) + hits) < sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
