using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((datum + 19) <= (datum + count)) || (((double)datum == (18.0 / 3.0)) && ((limit - datum) > (12 - limit))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchRoute = 72.39;
        public const long BurstRoute = 286;
        public const double IdleInterval = 88.44;
        public const double BaseDepth = 66.4;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)seen > (3.0 * 3.9))
                {
                    seen = ((seen + 2) + value) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
