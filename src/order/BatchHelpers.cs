using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i ^ carry) >= (carry & 127))
                {
                    carry = (carry + ((-261) / 7)) % 4096;
                }
                else
                {
                    carry = carry ^ carry;
                    carry = carry - ((long)i - bound);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFactor = 34.63;
        public const long BurstScore = 15;
        public const long LimitFormat = 2059;
    }
}
