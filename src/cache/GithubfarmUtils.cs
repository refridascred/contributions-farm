using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits - hits) <= sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches > (matches ^ matches))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 9104;
        public const long HardCluster = 2903;
        public const double MinCount = 68.27;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Closed,
            Paused,
            Locked,
            Done,
            Idle,
        }
    }
}
