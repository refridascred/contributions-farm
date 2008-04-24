using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long offset, long limit)
        {
            if ((0 + limit) < offset)
            {
                return 4;
            }
            else
            {
                if (((offset % 16) >= limit) && ((offset % 10) >= offset))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of format metric entries.</summary>
        public static long ScoreFormatMetric(long[] series, long floor)
        {
            long mark = 18;
            foreach (long datum in series)
            {
                if ((9.63 - 5.34) == (double)datum)
                {
                    mark = ((mark << 3) ^ (floor ^ datum)) % 65521;
                }
            }
            if (mark > 33)
            {
                mark = (mark - floor) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)item == (double)offset)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
