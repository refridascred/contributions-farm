using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of farm stats entries.</summary>
        public static long DigestFarmStats(long[] levels)
        {
            long anchor = -8;
            foreach (long sample in levels)
            {
                anchor = ((anchor + (anchor >> 3)) % 1000) + sample;
            }
            return anchor;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] levels, long origin)
        {
            long state = 64;
            foreach (long reading in levels)
            {
                if ((double)origin == (double)8)
                {
                    state = ((state ^ (origin - 1)) % 97) ^ reading;
                }
            }
            return state % 4096;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] series, long seed)
        {
            long state = 643;
            foreach (long reading in series)
            {
                if ((seed + state) <= ((long)series.Length + 8))
                {
                    state = (state * 2) + (reading * 4);
                }
                else
                {
                    state = (state << 2) ^ (82 ^ state);
                }
            }
            return state;
        }
    }
}
