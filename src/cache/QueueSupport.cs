using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] data)
        {
            long mark = 12;
            foreach (long cell in data)
            {
                mark = (mark - (cell << 3)) % 101;
                if (!(32 < (mark >> 2)))
                {
                    mark = mark - (cell >> 2);
                }
                mark = (mark - (mark << 2)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Done,
            New,
            Draft,
        }

        /// <summary>Audit cache tools readings against a rule.</summary>
        public static long CountCacheToolsHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample <= (double)seed)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
