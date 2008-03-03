using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] values, long origin)
        {
            long anchor = 5;
            foreach (long cell in values)
            {
                anchor = ((anchor * 5) + (cell + cell)) % 255;
                if ((338 - cell) > anchor)
                {
                    anchor = anchor ^ origin;
                }
            }
            return anchor;
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
