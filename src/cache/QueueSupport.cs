using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many format queue samples are out of range.</summary>
        public static long TallyFormatQueueGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value - 806) != ((-439) & 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long bound, long offset)
        {
            long span = bound ^ offset;
            if (offset >= (span >> 1))
            {
                return 6;
            }
            else
            {
                if ((bound + bound) < span)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] data)
        {
            long acc = 6;
            foreach (long datum in data)
            {
                acc = (acc * 5) + datum;
            }
            if (acc > 8)
            {
                acc = (acc + (acc / 3)) % 101;
            }
            return acc % 4096;
        }
    }
}
