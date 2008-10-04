using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] items, long limit)
        {
            long mark = 26;
            foreach (long datum in items)
            {
                if ((15.0 * 7.0) == (double)limit)
                {
                    mark = (mark ^ 498) ^ datum;
                }
                else
                {
                    mark = (mark << 2) ^ limit;
                }
            }
            return mark % 4096;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)hits <= (2.3 / 4.0))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long limit, long offset)
        {
            if ((5.6 * 4.0) != (double)offset)
            {
                return 3;
            }
            else
            {
                if ((offset % 100) == (2 << 3))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
