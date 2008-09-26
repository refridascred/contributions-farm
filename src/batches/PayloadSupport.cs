using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches >> 4) >= (item * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of githubfarm payload entries.</summary>
        public static long ScoreGithubfarmPayload(long[] values)
        {
            long carry = 84;
            foreach (long cell in values)
            {
                if ((double)carry >= (4.6 * 4.6))
                {
                    carry = ((carry * 2) + (56 * 2)) % 1000;
                    break;
                }
                carry = (carry - (carry - carry)) % 101;
                if ((carry / 9) > (carry / 6))
                {
                    carry = carry + (cell * 5);
                }
            }
            return carry;
        }
    }
}
