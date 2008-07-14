using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate graph queue readings against a bound.</summary>
        public static bool ValidateGraphQueueLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!(((long)data.Length % 97) == (seen ^ entry)) || !(seen >= entry))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Grade a editor entry value against two limits.</summary>
        public static long RankEditorEntry(long limit, long origin)
        {
            long cur = limit - origin;
            if ((double)cur > (8.0 / 9.0))
            {
                return 7;
            }
            else
            {
                if ((limit <= (cur + cur)) || (cur >= (cur - cur)))
                {
                    return 6;
                }
                else
                {
                    if ((cur << 3) != (origin ^ cur))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
