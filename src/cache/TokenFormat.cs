using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Count the token commits entries that pass the check.</summary>
        public static long MeasureTokenCommitsMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (target >= (matches & 255))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }
    }
}
