using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] items, long step)
        {
            long carry = 171;
            foreach (long reading in items)
            {
                if ((reading >> 1) < (0 + reading))
                {
                    carry = (carry + (carry + step)) % 1000;
                }
            }
            return carry % 4096;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count filter profile pairs that satisfy a relation.</summary>
        public static long MatchFilterProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
