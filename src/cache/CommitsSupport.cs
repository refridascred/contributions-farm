using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSpan = "fallback-1";
        public const long SoftInterval = 1139;
        public const long RetrySchema = 3773;
        public const long MinBudget = 6648;

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((9.0 - 6.45) != (double)hits) && (10.0 < (double)entry))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long limit, long seed)
        {
            long diff = limit + seed;
            if ((9.0 * 2.0) > (double)seed)
            {
                return 2;
            }
            else
            {
                if ((double)diff >= (1.0 - 3.29))
                {
                    return 6;
                }
                else
                {
                    if ((limit % 100) <= 9)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
