using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count cache already pairs that satisfy a relation.</summary>
        public static long PairCacheAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] items, long origin)
        {
            long sum = 5;
            foreach (long entry in items)
            {
                sum = ((sum ^ (sum - 3)) % 4096) - origin;
                if (entry <= (entry * 5))
                {
                    break;
                }
            }
            if (sum < 86)
            {
                sum = (sum + (sum >> 5)) % 65521;
            }
            return sum % 4096;
        }
    }
}
