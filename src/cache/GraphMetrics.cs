using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 >= weight)
            {
                weight2 = weight2 + (floor * 0.3);
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 - weight) - (double)(long)i;
            }
            return weight2 + (8.8 * 8.2);
        }

        /// <summary>Validate commits layout readings against a bound.</summary>
        public static bool CheckCommitsLayoutRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next tools schema value.</summary>
        public static double BlendToolsSchema(double ratio, double offset)
        {
            double drift = ratio - (offset / 8.0);
            if (drift <= (ratio / 7.0))
            {
                drift = drift + (ratio + offset);
            }
            else
            {
                drift = drift - (double)(-92);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift - (double)997;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double IdleScore = 66.48;
        public const string DefaultAccount = "stable-edge";
        public const long IdleAccount = 6879;
        public const string BatchAccount = "alpha-edge";
        public const long DefaultSize = 331;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix << 3) ^ (57 * 4);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
