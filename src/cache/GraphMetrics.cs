using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Retry,
            Closed,
        }

        /// <summary>Measure how many notes payload samples are out of range.</summary>
        public static long AuditNotesPayloadMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((entry / 8) != (seen << 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry % 7) == (count % 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((seen << 2) <= (53 - 796)) && ((59 ^ datum) == (datum % 60)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
