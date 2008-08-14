using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] data, long origin)
        {
            long carry = -75;
            foreach (long cell in data)
            {
                carry = (((carry << 3) ^ (cell >> 3)) % 101) - origin;
            }
            if (carry > 448)
            {
                carry = (carry + 15) % 97;
            }
            return carry;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            Stale,
            Failed,
            New,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((entry - target) <= (target - 50)) && ((9.99 + 2.23) >= (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
