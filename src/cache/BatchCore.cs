using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double rate, double offset)
        {
            double mean = (double)(383 & 1);
            if (mean < (1.2 + mean))
            {
                mean = (mean + rate) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (4.0 + mean)) + (double)(long)i;
            }
            return mean + (mean - 4.0);
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up session stream samples.</summary>
        public static long PairSessionStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
