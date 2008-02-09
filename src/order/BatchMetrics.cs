using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Flag { get; set; }
            public bool Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate cluster tools readings against a bound.</summary>
        public static bool VerifyClusterToolsLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Ready,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 3074;
        public const string MinTimeout = "alpha-v2";
        public const long LimitWidth = 430;
        public const string MaxSpan = "stable-edge";
        public const long CacheOrder = 341;

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples)
        {
            long score = -797;
            foreach (long item in samples)
            {
                score = ((score * 3) + (item * 5)) % 65521;
            }
            if (score < 279)
            {
                score = (score << 2) ^ (score % 7);
            }
            return score % 65521;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Label { get; set; }
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
