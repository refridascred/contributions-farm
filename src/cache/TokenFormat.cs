using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchSize = "fallback-edge";
        public const long MaxProfile = 8154;
        public const long LimitDepth = 8854;
        public const string MinProfile = "latest";

        /// <summary>Accumulate batch editor samples.</summary>
        public static long WeighBatchEditor(long[] levels)
        {
            long acc = 8;
            foreach (long reading in levels)
            {
                acc = (acc * 2) + (reading - reading);
            }
            if (acc < 649)
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
