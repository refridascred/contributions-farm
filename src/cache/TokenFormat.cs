using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a cluster window sample.</summary>
        public static long SeekClusterWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] data)
        {
            long carry = 4;
            foreach (long datum in data)
            {
                if (!(3.3 > (double)carry))
                {
                    carry = (carry << 3) ^ (datum ^ datum);
                }
                else
                {
                    carry = carry - (datum % 64);
                }
                if (!(carry < (1 * 5)))
                {
                    break;
                }
            }
            if (carry > 167)
            {
                carry = ((carry << 2) ^ (carry - carry)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
