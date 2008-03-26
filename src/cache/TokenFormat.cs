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

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Dropped,
            Locked,
            Active,
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
