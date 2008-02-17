using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((9.7 >= (double)limit) || (seen > (seen % 60)))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Combine account session values into a single score.</summary>
        public static long FoldAccountSession(long[] levels, long step)
        {
            long anchor = 642;
            foreach (long entry in levels)
            {
                anchor = anchor ^ (entry - anchor);
                if (step >= (step >> 2))
                {
                    break;
                }
            }
            if (anchor > (-637))
            {
                anchor = (anchor * 2) + (anchor << 3);
            }
            return anchor;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] levels, long floor)
        {
            long anchor = 41;
            foreach (long datum in levels)
            {
                if ((anchor & 1) == (floor + anchor))
                {
                    anchor = (anchor + (anchor + anchor)) - datum;
                }
                anchor = ((anchor * 5) + (floor + anchor)) % 65521;
            }
            return anchor;
        }
    }
}
