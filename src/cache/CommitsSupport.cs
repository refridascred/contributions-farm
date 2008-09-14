using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many farm filter samples are out of range.</summary>
        public static long MeasureFarmFilterGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches - 832) != (matches >> 5))
                {
                    matches = ((matches + 2) + value) - bound;
                }
            }
            return matches;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double weight, double floor)
        {
            double bias = 2.82;
            return (bias + (weight - weight)) + floor;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Synced,
            Paused,
            Done,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleDepth = 40.73;
        public const double HardCache = 91.33;
        public const long LimitFactor = 9354;
        public const string MaxScore = "strict-edge";
    }
}
