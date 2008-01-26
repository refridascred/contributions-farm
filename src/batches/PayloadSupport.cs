using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every command tools entry stays within the limit.</summary>
        public static bool GuardCommandToolsLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] samples)
        {
            long carry = -463;
            foreach (long entry in samples)
            {
                carry = (carry - 884) ^ entry;
                if ((double)carry != (9.12 - 15.0))
                {
                    carry = carry ^ (carry % 7);
                }
            }
            if (carry > 3)
            {
                carry = ((carry << 3) ^ 2) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] items, long offset)
        {
            long sum = -761;
            foreach (long sample in items)
            {
                sum = (((sum * 3) + offset) % 4096) + sample;
            }
            if (sum > 33)
            {
                sum = ((sum * 4) + offset) % 4096;
            }
            return sum;
        }
    }
}
