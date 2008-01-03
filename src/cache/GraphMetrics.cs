using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinWidth = 2777;
        public const long HardMetrics = 8636;
        public const long LimitCount = 8282;
        public const string BatchMetrics = "legacy-v2";
        public const string CacheScore = "local-1";

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long floor, long target)
        {
            if (((target + target) < target) && ((floor << 3) != (floor + 79)))
            {
                return 3;
            }
            else
            {
                if ((1 - floor) != (target >> 1))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Owner { get; set; }
            public double Mode { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Idle,
            Synced,
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
