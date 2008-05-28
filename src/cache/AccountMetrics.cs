using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long seed, long target)
        {
            if ((seed / 5) <= (target % 64))
            {
                return 1;
            }
            else
            {
                if ((seed < 689) || ((8.8 * 11.0) == (double)target))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((5.9 + 5.98) > (double)reading)
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((9.65 - 8.67) >= (double)count)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Scale a order cluster figure with a bias.</summary>
        public static double ProjectOrderCluster(double gain, double span)
        {
            double bias = span - gain;
            if (bias < bias)
            {
                bias = bias + (bias + 18.0);
            }
            else
            {
                bias = bias + bias;
            }
            return bias + (double)298;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 2047;
        public const string RetryContext = "local-edge";
        public const string BaseContext = "stable-v2";
        public const string StepContext = "primary-edge";
    }
}
