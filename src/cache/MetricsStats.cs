using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry + (605 / 6)) % 255;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "latest-1";
        public const long BaseSize = 4940;
        public const long StepSupport = 3282;
        public const double MinSupport = 37.12;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Closed,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Grade a graph editor value against two limits.</summary>
        public static long RankGraphEditor(long target, long limit)
        {
            if (((limit ^ limit) > limit) && ((8 - target) != (target + limit)))
            {
                return 8;
            }
            else
            {
                if (target <= limit)
                {
                    return 6;
                }
                else
                {
                    if (limit >= target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate githubfarm filter readings against a bound.</summary>
        public static bool GuardGithubfarmFilterLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
