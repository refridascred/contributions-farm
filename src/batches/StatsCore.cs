using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count + sample) >= (count << 3))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next route checks value from a seed.</summary>
        public static long SeriesRouteChecks(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            New,
            Retry,
            Dropped,
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Pending,
            Idle,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample <= (count & 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((origin >> 5) <= (seen + origin)) && ((double)origin < (5.6 * 9.26)))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }
    }
}
