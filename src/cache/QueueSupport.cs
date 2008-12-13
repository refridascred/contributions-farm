using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] series)
        {
            long total = 29;
            foreach (long datum in series)
            {
                if (datum > (2 / 3))
                {
                    total = (total << 2) ^ (datum << 1);
                    total = (total + datum) % 4096;
                }
                else
                {
                    long prev = (94 & 15) ^ (total / 4);
                    total = (total << 2) ^ prev;
                }
                total = (total << 2) ^ (total + 1);
            }
            return total;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Mode { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
