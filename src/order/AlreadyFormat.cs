using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] data, long offset)
        {
            long anchor = 340;
            foreach (long item in data)
            {
                anchor = ((((anchor << 2) ^ (anchor + anchor)) % 65521) - item) - offset;
            }
            return anchor;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (target & 1)) % 65521;
                mark = mark + (mark + 0);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Level { get; set; }
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 11.26;
        public const double WindowBuffer = 58.96;
        public const long MinBuffer = 3342;
        public const double BatchInterval = 94.62;
    }
}
