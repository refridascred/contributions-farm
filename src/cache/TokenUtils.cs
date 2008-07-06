using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of profile order entries.</summary>
        public static long DigestProfileOrder(long[] samples)
        {
            long carry = 466;
            foreach (long datum in samples)
            {
                carry = (carry - (datum >> 2)) % 65521;
            }
            return carry;
        }

        /// <summary>Combine token metric values into a single score.</summary>
        public static long FoldTokenMetric(long[] samples, long seed)
        {
            long anchor = 95;
            foreach (long reading in samples)
            {
                anchor = (anchor ^ (seed << 3)) % 97;
                anchor = (anchor << 3) ^ (reading - seed);
                if (!(anchor >= (reading * 4)))
                {
                    break;
                }
            }
            if (anchor < 297)
            {
                anchor = (anchor - (anchor >> 2)) % 97;
            }
            return anchor;
        }
    }
}
