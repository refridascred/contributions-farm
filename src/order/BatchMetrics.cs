using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] levels, long origin)
        {
            long acc = 7;
            foreach (long cell in levels)
            {
                acc = ((acc ^ 14) % 97) - cell;
                if ((4 / 8) > (acc + 176))
                {
                    acc = (acc * 5) + (acc - acc);
                }
                else
                {
                    acc = (acc ^ (origin - (long)levels.Length)) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftDepth = 1288;
        public const long RetryQueue = 19;
        public const double StepQueue = 15.24;
        public const long SoftTimeout = 3642;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryRatio = 2839;
        public const double BatchDepth = 16.86;
        public const long RetryFilter = 839;
        public const string DefaultFilter = "alpha-1";
        public const long IdleFilter = 9947;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Level { get; set; }
            public double Rank { get; set; }
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
