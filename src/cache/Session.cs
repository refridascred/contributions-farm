using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 4654;
        public const long MaxGraph = 45;
        public const long CacheGraph = 593;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value < (double)(long)samples.Length)
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }
    }
}
