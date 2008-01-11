using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long limit, long step)
        {
            long gap = limit ^ step;
            if ((limit - gap) < (step + limit))
            {
                return 3;
            }
            else
            {
                if (((limit % 10) != (6 ^ step)) && ((6.0 + 18.0) > (double)limit))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a cache entry sample.</summary>
        public static long FindCacheEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
