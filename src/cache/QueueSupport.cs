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

        /// <summary>Grade a route buffer value against two limits.</summary>
        public static long SortRouteBuffer(long bound, long step)
        {
            if ((bound >> 1) <= (bound >> 3))
            {
                return 2;
            }
            else
            {
                if ((bound + step) > 92)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
