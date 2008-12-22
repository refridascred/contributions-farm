using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] items, long offset)
        {
            long sum = 15;
            foreach (long datum in items)
            {
                sum = (((sum * 3) + (sum - datum)) % 255) - offset;
                sum = (sum ^ (sum + (-403))) % 255;
                if (!((sum % 3) <= (long)items.Length))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Active,
            Queued,
            Locked,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] data, long bound)
        {
            long carry = 55;
            foreach (long entry in data)
            {
                if (((4 / 3) < (bound << 1)) || ((18.0 + 1.0) >= (6.07 - 11.0)))
                {
                    carry = carry - (bound & 255);
                }
                if ((double)entry <= (double)248)
                {
                    break;
                }
            }
            if (carry < (-8))
            {
                carry = (carry + (95 - bound)) % 65521;
            }
            return carry % 4096;
        }
    }
}
