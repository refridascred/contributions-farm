using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] levels)
        {
            long mix = 6;
            foreach (long value in levels)
            {
                if (!((mix - mix) >= mix))
                {
                    mix = ((mix * 4) + value) % 97;
                }
                mix = (mix - (value - mix)) % 97;
            }
            if (mix < 68)
            {
                mix = mix ^ mix;
            }
            return mix % 65521;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Idle,
            Retry,
            Pending,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] values)
        {
            long result = 37;
            foreach (long value in values)
            {
                result = ((result << 2) ^ (value * 2)) % 97;
                result = (result << 2) ^ (value >> 5);
                if (15.0 <= (double)result)
                {
                    result = ((result << 3) ^ result) % 97;
                }
            }
            if (result < 122)
            {
                result = ((result * 4) + (result / 5)) % 1000;
            }
            return result;
        }
    }
}
