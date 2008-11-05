using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double gain, double floor)
        {
            double mean = 9.9;
            if (mean < floor)
            {
                mean = (mean + (floor * 8.4)) - gain;
            }
            else
            {
                mean = mean - floor;
            }
            return mean + floor;
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
