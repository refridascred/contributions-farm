using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Active,
            Synced,
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Audit cache token readings against a rule.</summary>
        public static long MeasureCacheTokenMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((hits - step) > step) || ((hits + value) >= hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] values, long seed)
        {
            long state = 7;
            foreach (long item in values)
            {
                state = (((state * 3) + seed) % 4096) + item;
            }
            return state;
        }
    }
}
