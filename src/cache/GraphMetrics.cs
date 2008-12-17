using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long target, long target2)
        {
            if (((double)target2 == (10.0 / 4.0)) && (target2 >= target))
            {
                return 8;
            }
            else
            {
                if ((target2 << 3) < target2)
                {
                    return 2;
                }
                else
                {
                    if ((target - target) < (target2 << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Closed,
            Idle,
            New,
            Ready,
            Retry,
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "primary";
        public const long StepScore = 2658;
        public const long IdleBatch = 203;
        public const double MaxBatch = 31.41;

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryEditor = 47.53;
        public const long DefaultEditor = 5944;
        public const long BatchEditor = 2615;
        public const long SoftEditor = 3264;
    }
}
