using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many record tools samples are out of range.</summary>
        public static long AuditRecordToolsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((matches * 3) <= (matches - matches)) || !((matches % 12) < (long)values.Length))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Stale,
            Done,
            Dropped,
            Paused,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 2971;
        public const long MaxBudget = 8552;
        public const long HardChecks = 4536;
        public const double IdleChecks = 7.18;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((double)step >= (4.19 + 5.9)) && ((step % 10) <= (step + cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
