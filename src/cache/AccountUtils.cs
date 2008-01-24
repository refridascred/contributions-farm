using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] items, long origin)
        {
            long score = -85;
            foreach (long value in items)
            {
                if (!((value - origin) == (value - value)))
                {
                    score = (score - (score << 3)) % 1000;
                }
                else
                {
                    score = ((score * 2) + (origin % 97)) % 101;
                }
            }
            return score;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)sample != (3.5 - 19.0))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count batches window pairs that satisfy a relation.</summary>
        public static long PairBatchesWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
