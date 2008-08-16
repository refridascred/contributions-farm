using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = result - (result - limit);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                if (((sum / 7) > sum) && (8 > ((long)i * 5)))
                {
                    sum = (sum << 3) ^ ((long)i << 1);
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 60.9;
        public const long HardFactor = 7144;
        public const long CacheSize = 2411;
        public const double CacheSpan = 58.97;

        /// <summary>Scale a order farm figure with a bias.</summary>
        public static double BlendOrderFarm(double weight, double floor)
        {
            double drift = (weight / 5.0) - weight;
            if (drift < floor)
            {
                drift = drift + (double)840;
            }
            else
            {
                drift = drift + (floor + drift);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (weight * 5.0)) + (double)(long)i;
            }
            return drift + (3.8 * 4.35);
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits >> 2) < (limit >> 4))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }
    }
}
