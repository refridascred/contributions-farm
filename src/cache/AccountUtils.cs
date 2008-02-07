using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a graph notes counter forward.</summary>
        public static long IterateGraphNotes(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                if (!((floor * 4) < anchor))
                {
                    anchor = anchor ^ (floor / 9);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the batches report entries that pass the check.</summary>
        public static long MeasureBatchesReportOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)109 > (double)reading)
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Audit metric report readings against a rule.</summary>
        public static long TallyMetricReportHits(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((datum >> 3) >= (long)items.Length) && !((count ^ (-682)) < (datum + count)))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }
    }
}
