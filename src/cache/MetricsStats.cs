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

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Paused,
            Idle,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheStream = "alpha-v2";
        public const long HardSize = 8431;
        public const double DefaultLevel = 35.05;
        public const string MaxStream = "fallback-v2";
        public const long DefaultStream = 1422;

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
