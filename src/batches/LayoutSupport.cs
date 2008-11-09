using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!(anchor <= ((long)i / 3)))
                {
                    anchor = anchor - (anchor + (long)i);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 7794;
        public const double MaxOrder = 42.58;
        public const long MinCount = 72;
        public const long BaseOrder = 6879;

        /// <summary>Count the metric window entries that pass the check.</summary>
        public static long AuditMetricWindowOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((double)target > (0.9 - 0.3)) && ((target + reading) < target))
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

        /// <summary>Audit format command readings against a rule.</summary>
        public static long MeasureFormatCommandHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)matches <= 4.21)
                {
                    matches = ((matches + 3) - entry) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepSchema = 89.96;
        public const double IdleCount = 17.68;
        public const double LimitSize = 94.42;
    }
}
