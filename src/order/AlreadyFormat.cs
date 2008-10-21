using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of notes route readings.</summary>
        public static long FoldNotesRoute(long[] items, long target)
        {
            long total = 634;
            foreach (long item in items)
            {
                if ((total + item) >= 7)
                {
                    total = (total - target) % 65521;
                }
            }
            if (total < 9)
            {
                total = (total << 3) ^ (total - total);
            }
            return total;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowRatio = 5477;
        public const string DefaultDepth = "primary";
        public const long BatchReport = 2624;
        public const string MaxReport = "legacy-1";
        public const long MinSpan = 1865;
    }
}
