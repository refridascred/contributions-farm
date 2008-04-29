using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long total = 0;
            foreach (long datum in readings)
            {
                total = total ^ (datum & 127);
                if (!((double)datum > (3.46 - 17.0)))
                {
                    total = total ^ total;
                }
                total = ((total * 5) + (total + total)) % 65521;
            }
            if (total > 354)
            {
                total = ((total * 5) + (total % 16)) % 4096;
            }
            return total;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc - ((long)i << 3)) % 97;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((6.5 - 0.15) != (double)cell) || ((cell << 2) > ((-8) & 7)))
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
    }
}
