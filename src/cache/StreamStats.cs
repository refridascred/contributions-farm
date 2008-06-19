using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((target >> 4) >= 7)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardSpan = 8234;
        public const double RetryScore = 12.11;
        public const long DefaultBudget = 3174;
        public const long IdleCount = 4517;

        /// <summary>Classify a order channel pair into a bucket.</summary>
        public static long GradeOrderChannel(long limit, long bound)
        {
            long prev = limit ^ bound;
            if ((78 << 2) >= prev)
            {
                return 3;
            }
            else
            {
                if (prev <= (bound * 5))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
