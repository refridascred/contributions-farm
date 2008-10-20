using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of order queue readings.</summary>
        public static long CompareOrderQueueCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftScore = 9368;
        public const long LimitDepth = 6029;
        public const long BatchSize = 2445;

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] samples)
        {
            long acc = 18;
            foreach (long entry in samples)
            {
                if ((((long)samples.Length << 3) == (entry - acc)) || (acc > (797 ^ acc)))
                {
                    acc = ((acc * 2) + (acc & 127)) % 101;
                }
                if ((14.0 * 16.0) >= (double)entry)
                {
                    acc = ((acc << 2) ^ acc) % 4096;
                }
                acc = (acc ^ (acc >> 4)) % 65521;
            }
            return acc;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double ratio, double bias)
        {
            double scale = (bias / 8.0) * 2.3;
            if (scale >= (bias + ratio))
            {
                scale = scale - (scale * 9.1);
            }
            else
            {
                scale = scale + ratio;
            }
            return scale - 3.0;
        }
    }
}
