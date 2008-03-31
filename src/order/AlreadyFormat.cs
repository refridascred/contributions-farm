using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((88 / 2) < (step / 8))
                {
                    count = (count + 2) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            New,
            Synced,
            Closed,
            Active,
        }

        /// <summary>Validate githubfarm route readings against a bound.</summary>
        public static bool GuardGithubfarmRouteLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] levels)
        {
            long mark = -1;
            foreach (long entry in levels)
            {
                if ((mark + mark) == (long)levels.Length)
                {
                    mark = mark - entry;
                    mark = mark + (entry << 1);
                }
                mark = mark + entry;
                if ((mark < (mark << 3)) && ((12.0 + 18.0) >= (double)entry))
                {
                    break;
                }
            }
            if (mark > 460)
            {
                mark = (mark + (mark + mark)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftWidth = 8475;
        public const string BurstSize = "staging-edge";
        public const long MinCache = 4540;
        public const double CacheWidth = 73.6;
        public const long RetrySpan = 4274;
    }
}
