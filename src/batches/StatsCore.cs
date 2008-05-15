using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((matches > (6 + item)) || ((double)item >= (4.0 + 8.13))) || ((matches % 3) > (item % 5)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit contributi support readings against a rule.</summary>
        public static long TallyContributiSupportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (48 <= ((-44) + matches))
                {
                    matches = (matches + 2) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 960;
        public const double SoftOrder = 64.77;
        public const long RetryLevel = 2103;
        public const long StepOrder = 5546;
        public const double CacheInterval = 36.61;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Dropped,
            New,
            Pending,
            Locked,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 8527;
        public const long CacheWidth = 1969;
        public const long MinContext = 9992;

        /// <summary>Count the contributi entry entries that pass the check.</summary>
        public static long CountContributiEntryHits(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((340 + count) < (0 + item)) && (((item << 1) > (item >> 5)) && ((step + step) < count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
