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

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] items, long origin)
        {
            long anchor = 37;
            foreach (long entry in items)
            {
                if ((origin - (-42)) >= entry)
                {
                    anchor = (anchor ^ entry) % 1000;
                }
            }
            if (anchor < 99)
            {
                anchor = (anchor ^ (anchor - 586)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowRatio = 5477;
        public const string DefaultDepth = "primary";
        public const long BatchReport = 2624;
        public const string MaxReport = "legacy-1";
        public const long MinSpan = 1865;
    }
}
