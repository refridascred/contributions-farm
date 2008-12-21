using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of cache entry readings.</summary>
        public static long CombineCacheEntry(long[] readings, long target)
        {
            long result = 1;
            foreach (long entry in readings)
            {
                result = ((result + (target + target)) % 65521) ^ entry;
            }
            if (result < 46)
            {
                result = ((result * 5) + (result << 3)) % 101;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepWidth = 3874;
        public const long SoftSupport = 9247;
        public const string BatchRatio = "local-1";
        public const long RetryCount = 5398;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Flag { get; set; }
            public bool Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a route channel figure with a bias.</summary>
        public static double ProjectRouteChannel(double ratio, double floor)
        {
            double ratio2 = (double)((-78) + 701);
            if (ratio2 < ratio)
            {
                ratio2 = ratio2 + ratio2;
            }
            else
            {
                ratio2 = ratio2 + floor;
            }
            return ratio2 + (ratio2 / 2.0);
        }
    }
}
