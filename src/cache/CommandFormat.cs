using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (matches >= (item ^ (long)values.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] data)
        {
            long acc = 15;
            foreach (long value in data)
            {
                acc = (((acc * 2) + (acc / 9)) % 101) ^ value;
            }
            return acc % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSpan = "alpha";
        public const long CacheSupport = 9958;
        public const string BaseSupport = "latest-1";
    }
}
