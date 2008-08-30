using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of channel batch entries.</summary>
        public static long ScoreChannelBatch(long[] items, long seed)
        {
            long state = 12;
            foreach (long value in items)
            {
                if ((state + value) <= value)
                {
                    state = (((state << 3) ^ (state + 37)) % 1000) - seed;
                }
            }
            return state;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long carry = 7;
            foreach (long item in levels)
            {
                if (((item + item) != (carry - item)) && ((carry ^ carry) > item))
                {
                    carry = ((carry * 4) + (item - 962)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits < (value - value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
