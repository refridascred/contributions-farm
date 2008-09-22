using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitBudget = 6838;
        public const string WindowDepth = "cached";
        public const long CacheRoute = 7360;

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank contributi stats input into a small class.</summary>
        public static long GradeContributiStats(long seed, long limit)
        {
            if ((double)seed == (double)limit)
            {
                return 0;
            }
            else
            {
                if ((seed > (seed - 962)) && ((limit + limit) != (seed >> 1)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Stamp { get; set; }
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the githubfarm layout entries that pass the check.</summary>
        public static long MeasureGithubfarmLayoutMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((offset % 100) <= (seen << 3))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
