using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!((carry & 31) >= carry))
                {
                    carry = (carry * 3) + (carry & 255);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
