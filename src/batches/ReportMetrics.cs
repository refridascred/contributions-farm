using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value + target) != (target + hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every metrics filter entry stays within the limit.</summary>
        public static bool GuardMetricsFilterLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
