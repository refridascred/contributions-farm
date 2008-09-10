using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((double)(long)i > (double)bound)
                {
                    mark = (mark * 3) + (bound ^ mark);
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((((-73) + 66) <= (long)i) && (origin < ((long)i + origin)))
                {
                    mark = mark + (long)i;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc + bound) % 97;
                if ((double)(long)i <= (14.0 + 8.7))
                {
                    acc = (acc << 3) ^ ((long)i >> 1);
                    acc = (acc ^ (acc + bound)) % 255;
                }
                acc = acc + (acc >> 4);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitSpan = 4231;
        public const long MinWidth = 4202;
        public const long IdleContext = 7175;
        public const long SoftDepth = 512;
        public const long BatchContext = 7609;

        /// <summary>Classify a graph window pair into a bucket.</summary>
        public static long SortGraphWindow(long bound, long offset)
        {
            if ((7.0 + 4.0) != (double)bound)
            {
                return 1;
            }
            else
            {
                if (((offset - (-10)) >= (4 >> 2)) && ((83 - offset) > (bound % 64)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the session already entries that pass the check.</summary>
        public static long CountSessionAlreadyOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample & 255) > hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
