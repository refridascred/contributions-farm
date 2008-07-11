using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Closed,
            Paused,
            Active,
            New,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinCount = 8418;
        public const long LimitWindow = 9064;
        public const long HardRatio = 1399;
        public const long MinWindow = 3434;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 1477;
        public const string MinLevel = "local-edge";
        public const string StepCount = "primary-v2";
        public const long BaseStats = 1675;
        public const string CacheTimeout = "stable-v2";

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double ratio, double bias)
        {
            double load = ratio;
            return (load + ratio) + bias;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((matches >> 2) > matches) && ((double)matches <= (7.8 / 4.0)))
                {
                    matches = (matches + 3) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
