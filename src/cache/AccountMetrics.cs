using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a commits batch figure with a bias.</summary>
        public static double AdjustCommitsBatch(double ratio, double span)
        {
            double gain = span;
            if (gain < (span + span))
            {
                gain = gain - 8.6;
            }
            else
            {
                gain = gain + (span + ratio);
            }
            return gain + (9.0 * 7.5);
        }

        /// <summary>Adjust a cache stats reading.</summary>
        public static double ProjectCacheStats(double rate, double span)
        {
            double drift = (double)((-6) + 396);
            if (drift < 8.2)
            {
                drift = ((drift - (double)(-3)) + rate) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (double)9;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a channel githubfarm reading by value.</summary>
        public static long SeekChannelGithubfarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter token samples are out of range.</summary>
        public static long TallyFilterTokenHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((4.7 - 5.28) < (double)origin)
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Derive the next batch stream value from a seed.</summary>
        public static long DeriveBatchStream(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                state = (state << 2) ^ 449;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
