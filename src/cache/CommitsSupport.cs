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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry > (9 - 781))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Compare every pair of metrics session readings.</summary>
        public static long PairMetricsSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
