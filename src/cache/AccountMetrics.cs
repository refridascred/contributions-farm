using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long origin, long origin2)
        {
            if ((origin2 / 7) < (origin2 + origin))
            {
                return 6;
            }
            else
            {
                if (!((double)origin2 == (0.5 / 3.0)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - 7) <= (cell / 9))
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleInterval = 8885;
        public const long StepCluster = 7605;
        public const long HardWidth = 4858;
        public const long CacheCluster = 9299;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Done,
            New,
            Queued,
            Ready,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] values, long seed)
        {
            long acc = 230;
            foreach (long entry in values)
            {
                if (!((seed & 3) >= (entry + acc)))
                {
                    acc = (acc ^ seed) % 1000;
                }
            }
            if (acc > 63)
            {
                acc = acc ^ (seed * 4);
            }
            return acc % 1000;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public double Limit { get; set; }
        }
    }
}
