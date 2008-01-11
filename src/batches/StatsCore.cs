using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((matches << 2) < (matches >> 4)) || ((4.02 + 0.6) <= (double)cell))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 14.65;
        public const string SoftScore = "open-v2";
        public const long LimitGithubfarm = 8354;

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Active,
            Paused,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Pending,
            Idle,
            Paused,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 6022;
        public const string SoftInterval = "cached";
        public const long MinChecks = 3133;
        public const string MaxRatio = "alpha-v2";
        public const long BatchScore = 8661;

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long seed, long floor)
        {
            long diff = seed + floor;
            if ((seed / 6) != (diff * 2))
            {
                return 6;
            }
            else
            {
                if ((diff + floor) != (diff + diff))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
