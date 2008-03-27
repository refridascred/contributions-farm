using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of graph contributi readings.</summary>
        public static long CompareGraphContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the buffer command entries that pass the check.</summary>
        public static long TallyBufferCommandMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((target / 7) <= (64 + 7))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleCount = 78.3;
        public const long BaseFactor = 4807;
        public const string DefaultDepth = "legacy-edge";
        public const string BaseWidth = "latest-edge";

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Done,
            Stale,
            Paused,
            New,
        }
    }
}
