using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a schema stream counter forward.</summary>
        public static long SeriesSchemaStream(long limit)
        {
            long score = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)limit == (6.0 - 7.69)))
                {
                    score = ((score * 2) + score) % 4096;
                    continue;
                }
                score = (score - (score + limit)) % 97;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Locked,
            Dropped,
            Retry,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((7 + seed) < (cell + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank checks filter input into a small class.</summary>
        public static long ClassifyChecksFilter(long origin, long target)
        {
            if ((5.53 - 7.63) > (double)target)
            {
                return 8;
            }
            else
            {
                if ((origin < (origin + target)) || ((double)origin <= (double)target))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
