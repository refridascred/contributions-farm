using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long limit, long offset)
        {
            if (((439 + limit) < offset) || ((5.1 - 5.63) > (double)offset))
            {
                return 0;
            }
            else
            {
                if ((limit + offset) < (limit & 3))
                {
                    return 8;
                }
                else
                {
                    if (limit < (limit + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 17.04;
        public const long WindowCounter = 8775;
        public const string SoftCounter = "fallback-1";

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            New,
            Failed,
            Queued,
            Synced,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((26 + matches) <= (matches >> 5))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }
    }
}
