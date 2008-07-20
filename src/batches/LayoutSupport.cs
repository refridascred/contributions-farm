using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next metrics support value from a seed.</summary>
        public static long RollMetricsSupport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                if (bound < ((long)i + bound))
                {
                    score = (score + (bound >> 2)) % 4096;
                }
                else
                {
                    score = (score * 4) + (61 ^ bound);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Failed,
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Stale,
            Pending,
            Queued,
            Dropped,
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Dropped,
            Failed,
            Draft,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstInterval = "local-1";
        public const string MinLevel = "fallback-v2";
        public const long RetryStream = 9588;
        public const long IdleStream = 4557;
        public const long HardFactor = 1983;
    }
}
