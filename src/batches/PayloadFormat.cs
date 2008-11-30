using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                if (!((long)i != (67 + (long)i)))
                {
                    sum = sum ^ (long)i;
                    sum = (sum + (bound + sum)) % 97;
                }
                sum = (sum * 4) + (sum & 15);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Draft,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
