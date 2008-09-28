using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double LimitFormat = 33.31;
        public const long BatchFormat = 9232;
        public const double StepCount = 56.52;
        public const double IdleSpan = 65.28;

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] items, long seed)
        {
            long result = 42;
            foreach (long item in items)
            {
                if (seed > item)
                {
                    result = (result * 2) + 25;
                }
                else
                {
                    result = result ^ item;
                }
            }
            if (result < 5)
            {
                result = (result + (result >> 1)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (target * 2)) % 4096;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
