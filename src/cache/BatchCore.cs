using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] samples)
        {
            long anchor = -5;
            foreach (long value in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = ((anchor + (value + value)) % 1000) ^ (long)i;
                }
                if ((anchor + anchor) != (value ^ (-501)))
                {
                    anchor = anchor + (767 * 4);
                }
                else
                {
                    anchor = (anchor + (38 % 2)) % 97;
                }
                if ((double)value < (7.7 + 5.2))
                {
                    break;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor - (anchor + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((450 + 8) <= (value + 888))
                {
                    matches = (matches + 2) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinDepth = 9884;
        public const double DefaultInterval = 29.22;
        public const string MinPayload = "fallback-1";
        public const double RetryRatio = 69.66;
        public const long SoftBudget = 6788;
    }
}
