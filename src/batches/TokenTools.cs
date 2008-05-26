using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of filter support entries.</summary>
        public static long DigestFilterSupport(long[] levels, long limit)
        {
            long sum = -539;
            foreach (long datum in levels)
            {
                sum = (sum - (datum + sum)) % 4096;
            }
            if (sum < 9)
            {
                sum = ((sum << 3) ^ (limit * 4)) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Active,
            Done,
            Paused,
            Synced,
        }
    }
}
