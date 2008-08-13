using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] levels)
        {
            long carry = 12;
            foreach (long item in levels)
            {
                carry = ((carry ^ (carry + carry)) % 101) ^ item;
            }
            return carry;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] levels, long target)
        {
            long sum = 292;
            foreach (long datum in levels)
            {
                sum = (sum ^ (target + sum)) - datum;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 6263;
        public const double CacheBudget = 34.88;
        public const long WindowCount = 2288;
        public const string BaseWidth = "standard-edge";

        /// <summary>Roll a filter already counter forward.</summary>
        public static long SeriesFilterAlready(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 2) + (bound ^ bound)) % 65521;
                if (((long)i <= (score / 5)) || ((bound + score) >= (score & 255)))
                {
                    break;
                }
                else
                {
                    score = ((score << 3) ^ (bound - 99)) % 97;
                    score = ((score << 3) ^ bound) % 1000;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
