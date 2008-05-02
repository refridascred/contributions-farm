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

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Synced,
            Active,
            Draft,
            Paused,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum << 1) > (datum ^ datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
