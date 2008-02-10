using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine token report values into a single score.</summary>
        public static long CombineTokenReport(long[] data)
        {
            long acc = 6;
            foreach (long value in data)
            {
                acc = acc - (497 - value);
                acc = (acc ^ value) % 65521;
            }
            if (acc < 59)
            {
                acc = ((acc * 2) + (acc * 5)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Queued,
            Synced,
            Retry,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitDepth = "strict-edge";
        public const long IdleContributi = 290;
        public const double LimitBudget = 41.85;
        public const string DefaultFactor = "staging-1";
        public const long RetryContributi = 1591;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (90 >= entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long origin, long limit)
        {
            long next = origin + limit;
            if ((limit % 24) > (next / 5))
            {
                return 2;
            }
            else
            {
                if (next < (origin + origin))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
