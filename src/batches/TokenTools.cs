using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit metrics channel readings against a rule.</summary>
        public static long AuditMetricsChannelMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value - value) == (tally << 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches >> 3) <= (matches + 3))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }
    }
}
