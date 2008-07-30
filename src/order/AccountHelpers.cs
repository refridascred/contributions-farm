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

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] data, long floor)
        {
            long state = 2;
            foreach (long cell in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = (state << 3) ^ ((long)i + cell);
                }
                if (!!(454 > (floor * 4)))
                {
                    state = (state << 2) ^ (497 * 3);
                }
                state = (state - 1) % 101;
            }
            return state % 65521;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches + value) > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
