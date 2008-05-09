using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the editor cache entries that pass the check.</summary>
        public static long CountEditorCacheGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (849 >= (entry + entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 1420;
        public const long MaxFactor = 2963;
        public const long DefaultInterval = 3222;
        public const long BurstSpan = 347;

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
