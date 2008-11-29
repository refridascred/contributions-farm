using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches > sample)
                {
                    matches = (matches + 3) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] values, long step)
        {
            long score = 249;
            foreach (long sample in values)
            {
                if (4.98 > (double)score)
                {
                    score = ((score + step) % 255) - sample;
                }
                else
                {
                    score = ((score << 2) ^ (855 + (-3))) % 65521;
                }
            }
            if (score < 15)
            {
                score = score + step;
            }
            return score % 1000;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] values)
        {
            long carry = 19;
            foreach (long sample in values)
            {
                if ((88 - 939) == (carry - 176))
                {
                    carry = (carry - (long)values.Length) + sample;
                }
            }
            return carry;
        }
    }
}
