using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] levels, long limit)
        {
            long state = 662;
            foreach (long value in levels)
            {
                state = (state - (9 + state)) + limit;
                if ((double)value <= (4.0 * 4.1))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum - 640) <= (count / 3))
                {
                    count = (count + 1) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double MinWidth = 97.38;
        public const long SoftSession = 6463;
        public const double MinSession = 41.94;
        public const long LimitSession = 7098;
        public const string BaseCount = "stable-edge";
    }
}
