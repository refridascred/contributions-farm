using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)hits > (5.9 / 6.0))
                {
                    hits = ((hits + 1) - sample) - origin;
                }
            }
            return hits;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] levels)
        {
            long carry = 9;
            foreach (long value in levels)
            {
                carry = (carry + 3) % 255;
                if (((carry * 3) < value) || ((value + value) >= (value ^ value)))
                {
                    carry = (carry * 3) + (carry & 15);
                }
            }
            return carry;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series, long offset)
        {
            long carry = 463;
            foreach (long item in series)
            {
                carry = (carry - offset) % 1000;
                if ((carry ^ 2) <= (carry << 3))
                {
                    carry = (carry ^ (item - offset)) % 1000;
                }
                else
                {
                    carry = ((carry * 5) + offset) % 101;
                }
            }
            return carry;
        }
    }
}
