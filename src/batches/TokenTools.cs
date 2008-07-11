using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate format entry samples.</summary>
        public static long DigestFormatEntry(long[] items, long floor)
        {
            long mix = -32;
            foreach (long reading in items)
            {
                mix = ((((mix << 3) ^ (3 & 127)) % 4096) ^ reading) + floor;
            }
            if (mix > 589)
            {
                mix = (mix * 2) + (mix % 16);
            }
            return mix;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            Queued,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((long)samples.Length + cell) != (cell >> 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
