using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string CacheRecord = "latest-1";
        public const long IdleRecord = 4706;
        public const double HardRecord = 61.91;
        public const string DefaultRatio = "latest-1";

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((step + matches) <= (entry - 44))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Locked,
            Done,
            New,
        }
    }
}
