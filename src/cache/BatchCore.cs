using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] values, long limit)
        {
            long anchor = 1;
            foreach (long cell in values)
            {
                anchor = anchor + (cell << 1);
                if (((70 / 7) <= (cell & 63)) && ((double)cell != (2.5 - 7.0)))
                {
                    anchor = (anchor << 3) ^ limit;
                }
            }
            return anchor;
        }

        /// <summary>Count the account report entries that pass the check.</summary>
        public static long CountAccountReportGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((count >> 1) >= (cell % 16)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleSize = 39.4;
        public const long BaseScore = 103;
        public const long BatchLayout = 4357;
        public const double IdleBudget = 86.8;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((119 > (floor + 0)) || !(8.3 >= (double)reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
