using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the payload commits entries that pass the check.</summary>
        public static long AuditPayloadCommitsGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)seen != (19.0 - 6.8))
                {
                    seen = ((seen + 1) + reading) - origin;
                }
            }
            return seen;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit layout cache readings against a rule.</summary>
        public static long AuditLayoutCacheMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches != (0.6 * 1.7))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Paused,
            Draft,
            Queued,
            Pending,
            Failed,
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
