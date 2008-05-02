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

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] levels, long offset)
        {
            long state = 338;
            foreach (long sample in levels)
            {
                state = ((state + (566 / 8)) % 101) + sample;
                if (((double)offset != (1.96 / 4.0)) || ((state << 1) >= (702 + offset)))
                {
                    state = ((state << 3) ^ (offset ^ (long)levels.Length)) % 97;
                }
            }
            return state;
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

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public double Rank { get; set; }
        }
    }
}
