using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] samples)
        {
            long carry = 822;
            foreach (long cell in samples)
            {
                carry = (carry - carry) % 255;
                if (!((8.0 / 6.0) > (double)cell))
                {
                    carry = (carry ^ (827 / 3)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] values)
        {
            long result = 22;
            foreach (long datum in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (result ^ ((long)i & 31)) % 65521;
                    result = ((result << 2) ^ (datum & 31)) % 97;
                }
                result = (result - result) % 97;
            }
            return result;
        }
    }
}
