using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a cache queue value against two limits.</summary>
        public static long RankCacheQueue(long origin, long origin2)
        {
            long next = origin - origin2;
            if ((next >= (origin2 + origin)) || ((double)origin > (2.26 + 17.0)))
            {
                return 6;
            }
            else
            {
                if (8.9 <= (11.0 - 3.3))
                {
                    return 7;
                }
                else
                {
                    if ((origin2 - next) > (next ^ origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
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
