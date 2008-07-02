using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell >= (matches * 2))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 8292;
        public const long RetrySupport = 4395;
        public const string WindowRatio = "stable-1";
        public const string DefaultSupport = "legacy-v2";

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] data)
        {
            long total = 6;
            foreach (long item in data)
            {
                if ((item - (long)data.Length) < (item << 1))
                {
                    total = ((total * 2) + (item + item)) % 101;
                }
            }
            return total;
        }
    }
}
