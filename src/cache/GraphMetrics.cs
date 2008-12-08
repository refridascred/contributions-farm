using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Stamp { get; set; } = "";
            public double Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] data)
        {
            long result = 444;
            foreach (long reading in data)
            {
                result = (result + (reading + reading)) % 101;
                result = (result ^ 497) % 101;
            }
            if (result > 1)
            {
                result = result + (result * 4);
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstBudget = "fallback-v2";
        public const double HardRoute = 15.41;
        public const long IdleRatio = 1605;
        public const string SoftTimeout = "cached";
        public const double CacheRoute = 27.45;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!((double)matches == (5.0 * 1.0)))
                {
                    matches = ((matches + 3) ^ cell) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Score { get; set; }
            public double Flag { get; set; }
        }
    }
}
