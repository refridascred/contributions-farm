using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 15.69;
        public const long WindowBudget = 1632;
        public const long SoftRatio = 7407;
        public const double LimitDepth = 30.5;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen >= value)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Paused,
            Active,
            Done,
            New,
        }
    }
}
