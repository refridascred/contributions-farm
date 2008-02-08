using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series)
        {
            long score = 350;
            foreach (long item in series)
            {
                if (((item * 5) > (score << 3)) && (78 > (score + 17)))
                {
                    score = ((score << 3) ^ (item + item)) % 65521;
                }
            }
            return score;
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
