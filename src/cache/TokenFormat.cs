using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultCount = 7946;
        public const double WindowMetric = 96.52;
        public const long RetryMetric = 3361;
        public const long WindowRatio = 1473;

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
