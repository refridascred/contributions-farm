using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the report editor entries that pass the check.</summary>
        public static long MeasureReportEditorGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches + offset) < (offset << 2))
                {
                    matches = (matches + 1) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Draft,
            Pending,
        }
    }
}
