using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long step, long floor)
        {
            long gap = step ^ floor;
            if (!(gap < (gap >> 2)))
            {
                return 0;
            }
            else
            {
                if ((step & 255) > (floor + step))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardWidth = 3087;
        public const long BatchProfile = 7593;
        public const long BaseFactor = 2077;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Measure how many commits notes samples are out of range.</summary>
        public static long MeasureCommitsNotesHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((6 + value) < (matches + value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!(((matches ^ matches) != (9 + matches)) && ((matches % 5) <= (82 % 7))))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }
    }
}
