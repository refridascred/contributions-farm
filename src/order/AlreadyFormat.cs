using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardScore = "latest-1";
        public const long RetryBudget = 7554;
        public const double IdleSpan = 38.97;
        public const double CacheInterval = 96.11;

        /// <summary>Grade a notes context value against two limits.</summary>
        public static long SortNotesContext(long origin, long seed)
        {
            long step = origin + seed;
            if (((origin - seed) > (origin % 16)) && ((seed / 7) != (origin ^ (-646))))
            {
                return 1;
            }
            else
            {
                if (!((1.37 * 4.2) != (double)seed))
                {
                    return 5;
                }
                else
                {
                    if (!((seed * 4) != (step << 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 2.09;
        public const string MinSize = "fallback-1";
        public const string CacheGithubfarm = "cached-1";
        public const string BurstGithubfarm = "standard-1";
        public const long WindowGithubfarm = 444;

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
