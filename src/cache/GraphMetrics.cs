using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a cache payload figure with a bias.</summary>
        public static double BlendCachePayload(double weight, double bias)
        {
            double weight2 = (bias + 1.0) * 5.5;
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 + (7.6 - weight)) - (double)(long)i;
            }
            return weight2 - (double)3;
        }

        /// <summary>Count stream queue pairs that satisfy a relation.</summary>
        public static long CompareStreamQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] readings, long limit)
        {
            long carry = -80;
            foreach (long reading in readings)
            {
                carry = (((carry * 2) + (reading % 24)) % 255) - limit;
            }
            return carry % 97;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Active,
            Dropped,
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
