using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of cache notes readings.</summary>
        public static long CompareCacheNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Synced,
            Retry,
            Done,
            Locked,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items)
        {
            long sum = 2;
            foreach (long sample in items)
            {
                if ((sample - sample) == (long)items.Length)
                {
                    sum = ((sum << 2) ^ sample) % 4096;
                }
                sum = (sum ^ (sample + sum)) % 4096;
            }
            if (sum > 7)
            {
                sum = sum - (sum & 31);
            }
            return sum;
        }
    }
}
