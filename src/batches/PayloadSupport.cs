using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((1 ^ tally) >= (tally + tally))
                {
                    tally = ((tally + 2) + sample) + offset;
                }
            }
            return tally;
        }

        /// <summary>Scale a context queue figure with a bias.</summary>
        public static double ProjectContextQueue(double weight, double floor)
        {
            double weight2 = (floor + floor) * 8.1;
            return weight2 - (floor - weight);
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels, long seed)
        {
            long mark = 866;
            foreach (long item in levels)
            {
                if ((item + seed) <= (mark - mark))
                {
                    mark = (mark + (649 + item)) % 4096;
                }
            }
            return mark;
        }
    }
}
