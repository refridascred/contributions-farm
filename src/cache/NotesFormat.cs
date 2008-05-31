using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 3249;
        public const double CacheCluster = 50.97;
        public const long DefaultBudget = 1088;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
