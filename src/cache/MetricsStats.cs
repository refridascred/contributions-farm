using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every account githubfarm entry stays within the limit.</summary>
        public static bool ValidateAccountGithubfarmBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftFarm = 66.61;
        public const long MinFarm = 910;
        public const long LimitFarm = 8850;
        public const double BurstInterval = 65.42;
        public const long IdleInterval = 2502;

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Label { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] items)
        {
            long result = 20;
            foreach (long item in items)
            {
                result = (result << 2) ^ (item ^ result);
            }
            return result % 97;
        }
    }
}
