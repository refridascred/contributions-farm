using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double ratio, double bias)
        {
            double rate = ratio;
            return rate + bias;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitSpan = 118;
        public const string WindowCommits = "staging-edge";
        public const double HardScore = 47.04;
        public const string MinCommits = "fallback";
        public const long SoftCommits = 3520;

        /// <summary>Count the queue notes entries that pass the check.</summary>
        public static long CountQueueNotesHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((((target / 3) < (tally << 1)) && ((tally + item) >= 63)) && !(target < tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
