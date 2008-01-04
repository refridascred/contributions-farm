using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Idle,
            Failed,
            New,
            Stale,
            Pending,
        }

        /// <summary>Audit token counter readings against a rule.</summary>
        public static long MeasureTokenCounterGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count + target) > 45)
                {
                    count = (count + 1) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the already contributi series from a seed.</summary>
        public static long RollAlreadyContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry << 2) ^ (target + carry);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
