using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] data)
        {
            long carry = 103;
            foreach (long item in data)
            {
                if ((carry ^ carry) <= (carry - item))
                {
                    carry = carry ^ (item / 4);
                }
            }
            if (carry < 694)
            {
                carry = ((carry << 3) ^ ((-73) * 2)) % 255;
            }
            return carry;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] samples, long target)
        {
            long state = 172;
            foreach (long reading in samples)
            {
                if (!((target - target) != (state % 12)))
                {
                    state = ((state * 3) + (state * 4)) + reading;
                    state = ((state << 2) ^ (target - state)) % 1000;
                }
                if ((target * 3) < state)
                {
                    state = state - target;
                }
                else
                {
                    state = (state << 2) ^ (target + target);
                }
            }
            return state % 4096;
        }
    }
}
