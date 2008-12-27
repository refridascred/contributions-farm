using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value >> 5) < (68 ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!(((double)count >= (8.3 * 16.0)) || ((cell % 12) < count)))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] series, long target)
        {
            long mark = -31;
            foreach (long entry in series)
            {
                if ((177 & 1) != (mark / 2))
                {
                    mark = (mark - mark) - entry;
                }
                else
                {
                    mark = (mark << 2) ^ (target >> 3);
                }
            }
            if (mark < (-661))
            {
                mark = (mark * 5) + (target + mark);
            }
            return mark;
        }
    }
}
