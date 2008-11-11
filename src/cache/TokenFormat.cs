using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate counter metrics samples.</summary>
        public static long CombineCounterMetrics(long[] samples, long floor)
        {
            long carry = 8;
            foreach (long datum in samples)
            {
                carry = carry + carry;
                if (!((5 + (long)samples.Length) <= floor))
                {
                    carry = (carry - (carry - datum)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Roll a record payload counter forward.</summary>
        public static long DeriveRecordPayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((double)score <= (4.74 - 3.0))
                {
                    score = (score ^ (offset << 3)) % 101;
                    break;
                }
                else
                {
                    score = (score * 3) + (-1);
                    score = (score - offset) % 4096;
                }
                if ((long)i != (67 - offset))
                {
                    score = score ^ (offset % 8);
                    break;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of profile filter entries.</summary>
        public static long FoldProfileFilter(long[] samples)
        {
            long total = 1;
            foreach (long item in samples)
            {
                if (!((item % 3) <= (item * 5)))
                {
                    total = ((total << 2) ^ (total + total)) % 4096;
                }
                if ((double)total > (2.54 / 2.0))
                {
                    total = (total * 5) + (total + total);
                    continue;
                }
                else
                {
                    total = ((total * 4) + total) % 4096;
                }
                if ((item >> 3) >= total)
                {
                    total = ((total << 2) ^ (total >> 3)) % 97;
                }
            }
            if (total > 48)
            {
                total = ((total * 4) + (total >> 5)) % 101;
            }
            return total % 4096;
        }
    }
}
