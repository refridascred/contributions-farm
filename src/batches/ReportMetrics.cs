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

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
