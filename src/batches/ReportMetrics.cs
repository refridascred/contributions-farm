using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardScore = 9433;
        public const string HardCommits = "fallback-1";
        public const double IdleInterval = 38.85;
        public const string HardSize = "alpha-v2";

        /// <summary>Fold a list of buffer session readings.</summary>
        public static long WeighBufferSession(long[] data, long floor)
        {
            long sum = 50;
            foreach (long sample in data)
            {
                sum = (sum ^ (8 + sum)) - floor;
                sum = (sum - sample) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
