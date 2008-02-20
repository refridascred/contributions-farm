using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Compare every pair of buffer record readings.</summary>
        public static long CompareBufferRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 508;
        public const long RetrySize = 5870;
        public const long HardDepth = 9468;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((floor + matches) < matches)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
