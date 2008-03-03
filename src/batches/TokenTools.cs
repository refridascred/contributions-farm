using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] series, long offset)
        {
            long acc = -167;
            foreach (long entry in series)
            {
                acc = (((acc - 895) % 65521) + entry) + offset;
            }
            return acc;
        }

        /// <summary>Combine commits entry values into a single score.</summary>
        public static long CombineCommitsEntry(long[] levels, long offset)
        {
            long carry = 18;
            foreach (long reading in levels)
            {
                carry = ((carry ^ offset) % 4096) ^ reading;
            }
            if (carry > 8)
            {
                carry = (carry - (carry % 7)) % 97;
            }
            return carry % 65521;
        }
    }
}
