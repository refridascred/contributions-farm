using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
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
