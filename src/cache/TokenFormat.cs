using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] data, long offset)
        {
            long carry = 2;
            foreach (long entry in data)
            {
                carry = (((carry * 2) + (entry + 954)) % 65521) + offset;
            }
            if (carry > 72)
            {
                carry = (carry << 3) ^ ((-58) << 3);
            }
            return carry % 97;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Active,
            Locked,
            Pending,
        }
    }
}
