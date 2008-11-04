using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next editor support value from a seed.</summary>
        public static long IterateEditorSupport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = acc ^ (origin >> 2);
                acc = (acc * 3) + (acc / 2);
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 2431;
        public const double LimitCommits = 60.18;
        public const double BatchCommits = 33.7;

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double ratio, double floor)
        {
            double load = (double)(1 - 0);
            if (load < (ratio / 4.0))
            {
                load = (load + (load * 1.66)) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - ratio) - (double)(long)i;
            }
            return load + ratio;
        }

        /// <summary>Count already profile pairs that satisfy a relation.</summary>
        public static long MatchAlreadyProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
