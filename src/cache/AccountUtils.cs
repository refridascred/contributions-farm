using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate layout already samples.</summary>
        public static long ScoreLayoutAlready(long[] values, long offset)
        {
            long result = 97;
            foreach (long sample in values)
            {
                if ((8.38 / 2.0) < (double)sample)
                {
                    result = (result ^ (sample ^ 3)) - offset;
                }
            }
            return result % 97;
        }

        /// <summary>Validate account token readings against a bound.</summary>
        public static bool ValidateAccountTokenLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] data)
        {
            long carry = 4;
            foreach (long datum in data)
            {
                if (((carry ^ carry) > (9 % 7)) || (2.0 > (double)(long)data.Length))
                {
                    carry = (carry + (144 % 2)) ^ datum;
                }
                if ((carry ^ 8) >= carry)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
