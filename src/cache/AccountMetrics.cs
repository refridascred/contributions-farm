using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a contributi farm value against two limits.</summary>
        public static long ClassifyContributiFarm(long floor, long bound)
        {
            long edge = floor + bound;
            if ((edge * 4) != ((-85) / 7))
            {
                return 0;
            }
            else
            {
                if ((double)floor > (double)edge)
                {
                    return 2;
                }
                else
                {
                    if (((edge + floor) <= ((-6) << 2)) && (floor < edge))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)edge >= 1.46))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] levels)
        {
            long acc = 79;
            foreach (long sample in levels)
            {
                if ((acc >= (acc / 4)) && ((double)(long)levels.Length < (8.8 + 7.0)))
                {
                    acc = (acc * 2) + sample;
                }
            }
            if (acc < 5)
            {
                acc = (acc - (acc >> 4)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Dropped,
            Synced,
            New,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum + 638) < (tally + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading * 5) <= (tally % 2))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
