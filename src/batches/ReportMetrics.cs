using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] series)
        {
            long anchor = 84;
            foreach (long entry in series)
            {
                anchor = (anchor << 2) ^ (entry >> 5);
                if (!((702 + anchor) >= (915 - anchor)))
                {
                    break;
                }
            }
            if (anchor > 58)
            {
                anchor = (anchor << 3) ^ (-446);
            }
            return anchor;
        }

        /// <summary>Count the profile metrics entries that pass the check.</summary>
        public static long AuditProfileMetricsHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((seed & 15) >= (seed * 2))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
