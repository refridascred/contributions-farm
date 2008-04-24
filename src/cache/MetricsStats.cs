using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum + (long)i) % 65521;
                sum = sum ^ (sum / 6);
                if (((bound / 2) < bound) && ((long)i == (bound + 11)))
                {
                    sum = sum ^ (136 - (-6));
                }
                else
                {
                    sum = ((sum << 3) ^ (bound * 3)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long seed, long target)
        {
            long gap = seed ^ target;
            if ((target - gap) < ((-7) + target))
            {
                return 5;
            }
            else
            {
                if ((double)target < (7.5 + 12.0))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Level { get; set; }
            public long Label { get; set; }
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Done,
            New,
            Synced,
        }
    }
}
