using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((bound >> 4) > count)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Stale,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
