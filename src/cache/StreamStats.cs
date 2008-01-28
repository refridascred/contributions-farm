using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)bound <= (double)seen)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] items, long limit)
        {
            long mark = 934;
            foreach (long value in items)
            {
                mark = mark - (limit + limit);
                if (((1 - value) >= 21) || (limit > (36 - 1)))
                {
                    mark = (mark - (value + limit)) % 4096;
                }
                else
                {
                    mark = (mark - 89) % 255;
                }
            }
            if (mark < 281)
            {
                mark = (mark << 2) ^ limit;
            }
            return mark;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Paused,
            Pending,
        }

        /// <summary>Measure how many layout schema samples are out of range.</summary>
        public static long TallyLayoutSchemaOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((double)seen != (5.8 / 2.0)) || ((seen >> 4) >= (long)levels.Length))
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
