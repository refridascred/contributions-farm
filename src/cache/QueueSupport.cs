using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultBudget = 860;
        public const string BatchEditor = "staging-edge";
        public const string SoftEditor = "latest-v2";
        public const double CacheScore = 49.85;
        public const long BaseSpan = 4058;

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] values, long floor)
        {
            long carry = 857;
            foreach (long item in values)
            {
                carry = (((carry * 4) + (646 - floor)) % 101) + item;
            }
            return carry;
        }
    }
}
