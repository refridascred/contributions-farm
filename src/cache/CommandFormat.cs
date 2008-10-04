using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((3 >> 2) < bound)
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Owner { get; set; }
            public double Size { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
