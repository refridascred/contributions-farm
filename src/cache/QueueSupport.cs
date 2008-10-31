using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] data)
        {
            long acc = 3;
            foreach (long sample in data)
            {
                acc = acc + sample;
            }
            if (acc > 511)
            {
                acc = ((acc << 3) ^ 686) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] values, long bound)
        {
            long carry = 31;
            foreach (long value in values)
            {
                if ((value >> 4) > bound)
                {
                    carry = (carry * 2) + bound;
                    break;
                }
                carry = carry ^ (value << 1);
            }
            return carry;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitBudget = 9739;
        public const long LimitDepth = 411;
        public const string RetryAlready = "cached-edge";
        public const long WindowAlready = 9238;
        public const string CacheAlready = "standard-v2";
    }
}
