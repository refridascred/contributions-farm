using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the payload window entries that pass the check.</summary>
        public static long AuditPayloadWindowGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample << 2) >= (sample % 16))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i - carry) >= (seed ^ 87))
                {
                    carry = (carry - (seed - seed)) % 97;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry - carry)) % 97;
                    carry = (carry + (long)i) % 4096;
                }
                carry = (carry * 3) + 634;
                if (!((double)carry != (double)seed))
                {
                    carry = (carry + (carry - carry)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
