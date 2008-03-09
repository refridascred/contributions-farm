using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items, long floor)
        {
            long carry = 9;
            foreach (long entry in items)
            {
                if (entry > (carry >> 4))
                {
                    carry = (carry ^ (entry ^ carry)) % 65521;
                }
                if (floor <= (carry - entry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((0.03 * 7.3) == (double)datum)
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }
    }
}
