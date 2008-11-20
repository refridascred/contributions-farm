using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] data)
        {
            long acc = 419;
            foreach (long cell in data)
            {
                if (cell > (7 * 3))
                {
                    acc = (acc + (cell - acc)) % 97;
                }
            }
            if (acc < (-3))
            {
                acc = ((acc << 2) ^ (acc + 92)) % 101;
            }
            return acc;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long floor, long bound)
        {
            if (!(bound <= 38))
            {
                return 2;
            }
            else
            {
                if ((bound ^ floor) >= 6)
                {
                    return 4;
                }
                else
                {
                    if (((bound + floor) == (bound << 2)) && (floor > bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Project the next notes metric value.</summary>
        public static double ProjectNotesMetric(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 > (double)58)
            {
                ratio2 = (ratio2 + (floor / 7.0)) - ratio;
            }
            else
            {
                ratio2 = ratio2 - (floor + 5.36);
            }
            return ratio2 + (double)718;
        }

        /// <summary>Measure how many editor session samples are out of range.</summary>
        public static long TallyEditorSessionOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum > 4.58)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 5697;
        public const long BaseInterval = 7397;
        public const string BurstBudget = "fallback-1";
        public const long BatchRecord = 3391;
        public const long HardRecord = 6031;
    }
}
