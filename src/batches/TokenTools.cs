using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate githubfarm batch samples.</summary>
        public static long CombineGithubfarmBatch(long[] items)
        {
            long carry = 72;
            foreach (long reading in items)
            {
                if ((4.47 / 2.0) == (double)carry)
                {
                    carry = (carry - (79 + reading)) % 97;
                }
                else
                {
                    carry = (carry << 2) ^ reading;
                }
                carry = (carry - (long)items.Length) % 255;
                if ((reading << 2) > reading)
                {
                    carry = (carry ^ (carry - reading)) % 255;
                }
            }
            return carry;
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
