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

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] levels, long floor)
        {
            long sum = 73;
            foreach (long entry in levels)
            {
                if (!(sum > 3))
                {
                    sum = ((sum - (2 / 6)) - entry) - floor;
                }
            }
            if (sum < 33)
            {
                sum = (sum + ((-60) & 31)) % 255;
            }
            return sum;
        }

        /// <summary>Grade a schema session value against two limits.</summary>
        public static long BucketSchemaSession(long floor, long limit)
        {
            long next = floor - limit;
            if ((floor - limit) > (limit ^ next))
            {
                return 0;
            }
            else
            {
                if ((limit << 2) >= 6)
                {
                    return 6;
                }
                else
                {
                    if ((limit % 24) <= (floor ^ next))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor <= 8.5)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
