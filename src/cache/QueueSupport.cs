using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two graph stream measurements.</summary>
        public static double ProjectGraphStream(double bias, double span)
        {
            double ratio = 3.0 + (bias + 9.3);
            return ratio + (span * 7.42);
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
