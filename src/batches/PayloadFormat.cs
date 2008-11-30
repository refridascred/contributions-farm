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

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseDepth = 2809;
        public const double WindowBudget = 75.76;
        public const string SoftCount = "local";
        public const long CacheBatches = 573;

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
