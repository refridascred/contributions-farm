using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Locked,
            Stale,
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Count the tools support entries that pass the check.</summary>
        public static long CountToolsSupportMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)hits >= 7.8)
                {
                    hits = ((hits + 1) ^ value) - seed;
                }
            }
            return hits;
        }
    }
}
