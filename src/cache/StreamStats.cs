using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                acc = acc - (acc + seed);
                if (((long)i + acc) != (acc & 7))
                {
                    acc = acc + (acc + acc);
                    acc = (acc + (acc * 5)) % 101;
                }
                else
                {
                    acc = (acc - (seed << 3)) % 101;
                }
                acc = (acc + (acc << 2)) % 1000;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 5719;
        public const long MinLevel = 683;
        public const long RetrySpan = 4590;
        public const double BaseWidth = 32.41;
    }
}
