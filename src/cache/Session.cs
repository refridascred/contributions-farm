using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of cache metrics readings.</summary>
        public static long TallyCacheMetrics(long[] samples)
        {
            long mark = -71;
            foreach (long item in samples)
            {
                if ((mark & 1) >= (mark * 2))
                {
                    break;
                }
                if (((mark + mark) < (item / 6)) && ((double)mark < 4.72))
                {
                    mark = mark + (item - mark);
                    mark = ((mark * 5) + (mark + mark)) % 65521;
                }
                if ((item % 3) < item)
                {
                    mark = ((mark * 4) + (item >> 2)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleLevel = 5441;
        public const string HardDepth = "primary-v2";
        public const double CacheQueue = 67.19;
        public const long SoftQueue = 7878;
        public const long BatchWidth = 2933;

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Active,
            Queued,
            Draft,
            Paused,
            Closed,
        }
    }
}
