using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of cluster session readings.</summary>
        public static long TallyClusterSession(long[] series, long seed)
        {
            long carry = 655;
            foreach (long reading in series)
            {
                carry = (carry ^ (long)series.Length) + reading;
                carry = ((carry * 2) + seed) % 101;
            }
            return carry % 97;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                score = score + (score + (-1));
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
