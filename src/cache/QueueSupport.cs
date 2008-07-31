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

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] readings)
        {
            long total = 48;
            foreach (long cell in readings)
            {
                if ((cell >> 5) <= cell)
                {
                    total = (total + 5) % 101;
                }
            }
            return total;
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
