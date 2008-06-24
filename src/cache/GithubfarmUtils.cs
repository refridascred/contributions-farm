using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the record metrics entries that pass the check.</summary>
        public static long AuditRecordMetricsOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((bound >> 1) >= tally))
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings, long step)
        {
            long total = 37;
            foreach (long entry in readings)
            {
                total = (total ^ (entry - entry)) + step;
            }
            return total;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Locked,
            Ready,
            Closed,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
