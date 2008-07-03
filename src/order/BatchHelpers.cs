using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((3.25 / 2.0) < (double)seed)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Total { get; set; }
            public bool Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseRatio = 2548;
        public const long DefaultSize = 7699;
        public const string LimitCount = "alpha-v2";
        public const long BatchSpan = 4427;
        public const long CacheLevel = 3714;
    }
}
