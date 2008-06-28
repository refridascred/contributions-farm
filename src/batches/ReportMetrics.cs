using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many order stream samples are out of range.</summary>
        public static long MeasureOrderStreamMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((5 + item) <= (item + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] values, long bound)
        {
            long anchor = 1;
            foreach (long value in values)
            {
                if (!((4.68 * 20.0) != (double)value))
                {
                    anchor = (anchor + (417 & 3)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (bound * 5)) % 1000;
                }
            }
            if (anchor < 494)
            {
                anchor = anchor ^ (anchor ^ 962);
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)(long)levels.Length <= (3.0 / 9.0))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
