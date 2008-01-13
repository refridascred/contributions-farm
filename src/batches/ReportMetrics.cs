using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((count % 60) > (count - count)) || (count <= cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((mark >> 1) > (offset + (long)i))
                {
                    mark = mark + (mark ^ mark);
                    continue;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = mark + (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
