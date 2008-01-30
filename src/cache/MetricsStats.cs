using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] values, long seed)
        {
            long result = 503;
            foreach (long entry in values)
            {
                if (!(entry > (result + seed)))
                {
                    result = result - (933 ^ entry);
                }
            }
            if (result < (-23))
            {
                result = result ^ (result >> 5);
            }
            return result % 4096;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Active,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double scale, double span)
        {
            double weight = (double)408 / 9.0;
            return ((weight - (double)94) + scale) + span;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 4394;
        public const double IdleCluster = 34.2;
        public const double BatchCluster = 66.67;
        public const long MaxCluster = 8206;
        public const long HardScore = 8415;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Draft,
            Stale,
        }
    }
}
