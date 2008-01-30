using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Closed,
            Retry,
            Locked,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 9800;
        public const string StepFilter = "fallback";
        public const string RetryBudget = "staging-1";
        public const double WindowSpan = 27.44;

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache graph readings against a rule.</summary>
        public static long TallyCacheGraphGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((87 % 100) <= (item ^ 8)) || (hits > origin))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a route stats reading by value.</summary>
        public static long LookupRouteStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 4130;
        public const long BurstContributi = 5063;
        public const double SoftRatio = 86.82;
    }
}
