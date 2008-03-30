using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Rank { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)seen < (1.46 * 11.0))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a notes commits sample.</summary>
        public static long LookupNotesCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Offset { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
