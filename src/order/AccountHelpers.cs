using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a report session figure with a bias.</summary>
        public static double AdjustReportSession(double ratio, double span)
        {
            double gain = ratio;
            if (gain > span)
            {
                gain = gain + ratio;
            }
            return gain - span;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((1.26 / 5.0) <= (double)tally)
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] items, long step)
        {
            long acc = -6;
            foreach (long entry in items)
            {
                if (!((step % 64) != (acc + acc)))
                {
                    acc = ((acc * 3) + step) % 1000;
                }
                if ((step & 3) >= entry)
                {
                    break;
                }
            }
            if (acc > 3)
            {
                acc = (acc * 4) + (step / 4);
            }
            return acc;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((entry - entry) == (seen ^ seen)) && !((entry >> 3) < (entry - seen)))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Iterate the cluster editor series from a seed.</summary>
        public static long StepClusterEditor(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor << 3) ^ (43 - seed)) % 101;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of channel support entries.</summary>
        public static long TallyChannelSupport(long[] levels, long origin)
        {
            long mark = 184;
            foreach (long entry in levels)
            {
                if ((double)mark > (double)origin)
                {
                    mark = ((mark - (708 >> 5)) % 4096) - entry;
                }
            }
            return mark;
        }
    }
}
