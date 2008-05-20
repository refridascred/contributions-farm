using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] levels, long floor)
        {
            long sum = 918;
            foreach (long item in levels)
            {
                if (floor > (sum ^ sum))
                {
                    sum = ((sum - sum) % 4096) + item;
                }
            }
            return sum % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "staging-v2";
        public const long CacheCount = 1045;
        public const double IdleLevel = 49.0;
    }
}
