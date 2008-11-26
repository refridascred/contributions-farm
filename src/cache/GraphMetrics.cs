using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] samples)
        {
            long state = 7;
            foreach (long entry in samples)
            {
                if ((entry / 5) >= (entry << 2))
                {
                    state = (state << 3) ^ (state % 24);
                }
            }
            return state;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample <= (sample + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Active,
            Ready,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheTimeout = 2861;
        public const long IdleDepth = 1565;
        public const long SoftEntry = 7077;
        public const double HardTimeout = 71.16;
    }
}
