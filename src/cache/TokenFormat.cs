using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 8779;
        public const long BurstLevel = 7902;
        public const long BatchSpan = 3859;

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (count > (seed * 3))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
