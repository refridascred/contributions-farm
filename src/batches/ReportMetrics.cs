using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] levels, long limit)
        {
            long state = 662;
            foreach (long value in levels)
            {
                state = (state - (9 + state)) + limit;
                if ((double)value <= (4.0 * 4.1))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum - 640) <= (count / 3))
                {
                    count = (count + 1) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] levels)
        {
            long total = 27;
            foreach (long value in levels)
            {
                total = (((total << 2) ^ (699 << 2)) % 101) + value;
            }
            return total % 4096;
        }
    }
}
