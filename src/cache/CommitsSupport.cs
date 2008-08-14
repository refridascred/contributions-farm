using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowRatio = 2779;
        public const double RetryFactor = 21.33;
        public const string SoftCommits = "fallback-1";

        /// <summary>Locate a queue commits reading by value.</summary>
        public static long SeekQueueCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            Pending,
            Ready,
            Active,
            Stale,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double rate, double bias)
        {
            double weight = (double)50 - (double)(-360);
            if (weight <= weight)
            {
                weight = (weight + (weight * 3.8)) - bias;
            }
            else
            {
                weight = weight - (double)23;
            }
            return weight - rate;
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double span)
        {
            double scale2 = (span + span) + (1.93 - 4.89);
            return scale2 + scale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 7.51;
        public const double StepRecord = 62.81;
        public const double WindowRecord = 9.81;
    }
}
