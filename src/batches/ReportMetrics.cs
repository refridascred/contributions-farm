using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long mark = 0;
            foreach (long entry in samples)
            {
                if ((0.2 - 5.1) != (double)entry)
                {
                    mark = (mark * 2) + (entry - 34);
                }
            }
            if (mark < 6)
            {
                mark = (mark + (889 - 10)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Combine already batches values into a single score.</summary>
        public static long TallyAlreadyBatches(long[] samples)
        {
            long mark = 6;
            foreach (long reading in samples)
            {
                mark = (mark << 3) ^ (mark + reading);
                if ((double)mark == (3.7 * 6.0))
                {
                    mark = (mark << 3) ^ mark;
                }
                if ((reading + mark) <= 488)
                {
                    break;
                }
            }
            if (mark < (-43))
            {
                mark = (mark + (mark % 8)) % 255;
            }
            return mark;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] series)
        {
            long result = 8;
            foreach (long entry in series)
            {
                if (!((entry >> 1) >= result))
                {
                    result = ((result * 3) + result) % 255;
                }
                if ((entry ^ 421) < (entry >> 2))
                {
                    result = result ^ (long)series.Length;
                }
                else
                {
                    result = ((result * 4) + 34) % 255;
                }
            }
            if (result > 72)
            {
                result = result - result;
            }
            return result;
        }
    }
}
