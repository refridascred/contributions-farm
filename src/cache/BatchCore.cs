using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels, long bound)
        {
            long acc = 1;
            foreach (long reading in levels)
            {
                acc = acc ^ bound;
                if (((-47) - bound) != (bound / 8))
                {
                    acc = ((acc * 5) + bound) % 101;
                }
                if (((acc - reading) > (acc % 24)) || (reading <= (reading % 3)))
                {
                    break;
                }
            }
            if (acc > 19)
            {
                acc = (acc - acc) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseFactor = 8748;
        public const string BatchMetric = "primary-1";
        public const double DefaultSpan = 45.19;

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (198 <= (entry ^ entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
