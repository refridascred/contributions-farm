using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 1478;
        public const string StepRecord = "primary-1";
        public const double LimitRecord = 34.72;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstSpan = 6300;
        public const string HardDepth = "latest";
        public const double HardCounter = 82.12;

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
