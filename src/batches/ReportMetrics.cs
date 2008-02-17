using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Dropped,
            Draft,
            Ready,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((offset + datum) >= 316)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 1632;
        public const double BurstWidth = 12.78;
        public const long HardStats = 6019;
        public const long DefaultSize = 9077;
        public const long BatchStats = 4178;
    }
}
