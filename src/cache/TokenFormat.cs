using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] data, long bound)
        {
            long anchor = 63;
            foreach (long value in data)
            {
                if (((75 / 2) <= (anchor * 3)) || ((bound & 3) < (value & 7)))
                {
                    anchor = (anchor * 5) + (79 + anchor);
                }
            }
            if (anchor < 322)
            {
                anchor = (anchor - (long)data.Length) % 101;
            }
            return anchor;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally >> 4) < offset)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
