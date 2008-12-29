using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate counter filter samples.</summary>
        public static long TallyCounterFilter(long[] levels)
        {
            long anchor = 18;
            foreach (long datum in levels)
            {
                if ((140 > (anchor / 2)) || ((anchor - anchor) == (datum + (long)levels.Length)))
                {
                    anchor = anchor - (anchor & 255);
                }
            }
            if (anchor > 651)
            {
                anchor = (anchor * 5) + (anchor * 5);
            }
            return anchor;
        }

        /// <summary>Count the notes command entries that pass the check.</summary>
        public static long AuditNotesCommandOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!(count >= origin))
                {
                    count = (count + 2) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)tally > (4.6 * 14.0))
                {
                    tally = ((tally + 2) ^ value) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double rate, double span)
        {
            double ratio = rate;
            if (ratio >= rate)
            {
                ratio = ratio - (double)140;
            }
            return ratio - (span - rate);
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double bias, double offset)
        {
            double weight = (double)(926 & 63);
            if (weight < offset)
            {
                weight = weight + (bias + 18.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (double)3) + (double)(long)i;
            }
            return weight + (weight + weight);
        }
    }
}
