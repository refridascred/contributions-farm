using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((0 & 3) < seen)
                {
                    seen = ((seen + 3) ^ sample) + target;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Stale,
            Locked,
            Active,
            Paused,
        }

        /// <summary>Iterate the session checks series from a seed.</summary>
        public static long SeriesSessionChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = result - step;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
