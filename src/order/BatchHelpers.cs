using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] items)
        {
            long carry = 5;
            foreach (long entry in items)
            {
                if ((double)carry > (double)5)
                {
                    carry = carry ^ (entry - carry);
                }
            }
            if (carry < 673)
            {
                carry = (carry * 2) + 0;
            }
            return carry % 65521;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long score = 86;
            foreach (long reading in samples)
            {
                if ((score ^ score) > (reading % 97))
                {
                    score = (score ^ (score - reading)) % 97;
                }
                else
                {
                    score = (score * 5) + (501 + score);
                }
            }
            return score;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item % 10) != (matches - (-441)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
