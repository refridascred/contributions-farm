using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every counter batch entry stays within the limit.</summary>
        public static bool GuardCounterBatchLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 6074;
        public const long LimitCommits = 2869;
        public const long CacheSpan = 1734;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                if ((target + (long)i) < carry)
                {
                    carry = (carry << 3) ^ ((long)i - carry);
                    carry = carry ^ (target + (long)i);
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
