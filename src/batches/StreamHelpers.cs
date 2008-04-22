using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Dropped,
            Active,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((98 % 3) < ((long)values.Length * 3))
                {
                    seen = ((seen + 3) + datum) - offset;
                }
            }
            return seen;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheBudget = 5967;
        public const string WindowCount = "fallback-v2";
        public const long LimitBudget = 4749;
        public const long HardSpan = 4521;
        public const string MaxContext = "strict-v2";

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Level { get; set; } = "";
            public double Rank { get; set; }
            public string Count { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
