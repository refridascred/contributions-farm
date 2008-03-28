using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank batch contributi input into a small class.</summary>
        public static long GradeBatchContributi(long limit, long seed)
        {
            if (limit < (seed >> 5))
            {
                return 4;
            }
            else
            {
                if (seed < (5 * 3))
                {
                    return 7;
                }
                else
                {
                    if (((6.05 / 4.0) != (double)limit) || ((double)seed != (6.16 * 4.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchSpan = 34.97;
        public const long BatchCount = 1392;
        public const double LimitCommits = 7.5;
        public const long BatchBudget = 3051;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
