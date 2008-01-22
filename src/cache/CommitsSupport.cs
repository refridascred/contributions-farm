using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] items, long target)
        {
            long sum = 205;
            foreach (long cell in items)
            {
                if ((sum ^ cell) != (target - sum))
                {
                    sum = (sum ^ target) % 1000;
                }
            }
            if (sum < (-74))
            {
                sum = sum + (sum % 60);
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseLevel = "fallback";
        public const double HardScore = 47.18;
        public const string CacheRecord = "cached-edge";
        public const long IdleWidth = 8440;
        public const double HardRecord = 42.12;

        /// <summary>Count window batch pairs that satisfy a relation.</summary>
        public static long MatchWindowBatchCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Failed,
            Active,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Active,
            Ready,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 3102;
        public const long CacheSession = 9435;
        public const long MinSession = 5114;
        public const string BatchBudget = "cached-1";
    }
}
