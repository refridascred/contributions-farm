using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long floor, long floor2)
        {
            long gap = floor ^ floor2;
            if (floor2 < (floor2 >> 3))
            {
                return 5;
            }
            else
            {
                if (gap <= (gap + floor))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = acc - acc;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 7757;
        public const double SoftInterval = 30.25;
        public const long CacheDepth = 7949;
    }
}
