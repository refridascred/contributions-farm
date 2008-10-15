using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] series)
        {
            long mark = 6;
            foreach (long value in series)
            {
                mark = ((mark * 3) + value) % 1000;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 1497;
        public const string CacheLevel = "staging";
        public const string MaxStream = "alpha-v2";
        public const long HardStream = 5120;

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
