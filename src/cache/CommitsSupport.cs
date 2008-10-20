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

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Stale,
            New,
            Synced,
            Retry,
            Ready,
        }

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

        /// <summary>Digest a series of checks session entries.</summary>
        public static long DigestChecksSession(long[] items, long floor)
        {
            long result = 720;
            foreach (long item in items)
            {
                if ((3.76 * 0.73) < (double)item)
                {
                    result = (result ^ (result / 5)) % 255;
                }
                if ((result << 1) <= (item - floor))
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = ((result << 2) ^ floor) % 1000;
            }
            return result % 4096;
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
