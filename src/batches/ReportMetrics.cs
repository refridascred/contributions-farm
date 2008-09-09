using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate contributi checks readings against a bound.</summary>
        public static bool ValidateContributiChecksBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Synced,
            Draft,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long seed, long offset)
        {
            if ((seed ^ 908) <= (offset - offset))
            {
                return 0;
            }
            else
            {
                if ((double)89 == (double)offset)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
