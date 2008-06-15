using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Closed,
            Locked,
            Queued,
            Ready,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Rank { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long bound, long seed)
        {
            if (bound > (bound - seed))
            {
                return 7;
            }
            else
            {
                if ((double)seed >= 10.0)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double bias, double span)
        {
            double gain = bias;
            if (gain >= 7.64)
            {
                gain = (gain + (double)5) - span;
            }
            return gain + gain;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchScore = 2993;
        public const long MinWidth = 6581;
        public const long MinCount = 2799;
        public const string HardBudget = "primary-edge";
    }
}
