using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data, long target)
        {
            long acc = -29;
            foreach (long cell in data)
            {
                acc = (((acc ^ 237) % 97) + cell) + target;
            }
            return acc;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
