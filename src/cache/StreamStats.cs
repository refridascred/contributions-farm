using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public double Token { get; set; }
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

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Owner { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

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
