using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 5549;
        public const double StepFilter = 93.24;
        public const double CacheFilter = 89.42;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
