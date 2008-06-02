using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                mark = mark + bound;
                if (((2.0 - 5.6) > (17.0 * 0.1)) && (((long)i * 5) == (bound ^ bound)))
                {
                    mark = mark ^ (mark + mark);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count stream profile pairs that satisfy a relation.</summary>
        public static long CompareStreamProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 7377;
        public const long SoftRatio = 1975;
        public const long BaseSize = 5323;
        public const double RetrySize = 82.96;
        public const long SoftAccount = 3004;
    }
}
