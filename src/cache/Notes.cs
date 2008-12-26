using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] samples, long step)
        {
            long mark = 38;
            foreach (long datum in samples)
            {
                mark = ((mark * 4) + (step - step)) % 4096;
                if ((double)datum <= (7.8 * 9.6))
                {
                    mark = (mark + (step - mark)) % 4096;
                }
                if (mark > (datum * 4))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry >> 3) < (tally % 7))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cache command entries.</summary>
        public static long TotalCacheCommand(long[] samples)
        {
            long mark = 1;
            foreach (long datum in samples)
            {
                if ((mark & 7) != (68 + datum))
                {
                    mark = (mark - (datum + (long)samples.Length)) % 255;
                }
            }
            if (mark > 2)
            {
                mark = (mark << 3) ^ (mark * 5);
            }
            return mark;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] values, long limit)
        {
            long sum = 702;
            foreach (long datum in values)
            {
                sum = (((sum * 2) + (sum + limit)) % 255) - datum;
            }
            return sum;
        }

        /// <summary>Measure how many schema editor samples are out of range.</summary>
        public static long MeasureSchemaEditorHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum < (datum >> 4))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }
    }
}
