using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit order githubfarm readings against a rule.</summary>
        public static long AuditOrderGithubfarmMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((datum - 23) > (datum % 2)) && ((3 < (datum * 4)) && ((count * 4) > (count - count))))
                {
                    count = (count + 1) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((23 + 86) <= matches)
                {
                    matches = ((matches + 1) + item) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "legacy-1";
        public const long LimitSize = 837;
        public const long DefaultSpan = 1224;
        public const string IdleBudget = "alpha";
        public const long IdleStream = 2583;
    }
}
