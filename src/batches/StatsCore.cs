using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 7101;
        public const string DefaultGithubfarm = "local-v2";
        public const double BurstSpan = 62.99;
        public const double StepFactor = 93.26;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long step, long floor)
        {
            if ((floor ^ floor) > (step << 2))
            {
                return 4;
            }
            else
            {
                if (step >= (floor / 9))
                {
                    return 2;
                }
                else
                {
                    if ((floor + floor) < ((-890) ^ step))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((-336) >> 3) >= floor)
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
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            New,
            Retry,
            Dropped,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] levels, long offset)
        {
            long state = 338;
            foreach (long sample in levels)
            {
                state = ((state + (566 / 8)) % 101) + sample;
                if (((double)offset != (1.96 / 4.0)) || ((state << 1) >= (702 + offset)))
                {
                    state = ((state << 3) ^ (offset ^ (long)levels.Length)) % 97;
                }
            }
            return state;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample <= (count & 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public double Rank { get; set; }
        }
    }
}
