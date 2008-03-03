using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MaxOrder = 97.76;
        public const long CacheOrder = 1281;
        public const double BurstSpan = 46.1;
        public const double RetryWidth = 70.96;
        public const long MinFactor = 8514;

        /// <summary>Compare every pair of report window readings.</summary>
        public static long OverlapReportWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
