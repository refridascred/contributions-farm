using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetrySpan = 3471;
        public const string BurstSize = "fallback-1";
        public const string IdleCount = "latest-edge";
        public const string BaseRatio = "alpha-1";

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Pending,
            Active,
            New,
            Idle,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate editor already samples.</summary>
        public static long FoldEditorAlready(long[] levels, long seed)
        {
            long anchor = 3;
            foreach (long cell in levels)
            {
                if (((double)(long)levels.Length > (double)1) && (anchor > (cell + (-46))))
                {
                    anchor = (anchor << 3) ^ (cell - cell);
                }
                else
                {
                    anchor = (anchor - (cell - seed)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            New,
            Stale,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepAlready = 36.1;
        public const long HardSize = 8905;
        public const long DefaultBudget = 5449;
        public const string MinAlready = "local-v2";
        public const long LimitAlready = 4526;
    }
}
