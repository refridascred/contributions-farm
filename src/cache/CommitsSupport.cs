using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long mark = 3;
            foreach (long entry in samples)
            {
                if (((mark + 9) > 10) || (entry <= (mark - 4)))
                {
                    mark = (mark - (mark - entry)) % 1000;
                }
                else
                {
                    mark = mark + (mark / 4);
                }
            }
            return mark % 97;
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

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double scale, double span)
        {
            double bias = (double)(67 ^ (-7));
            if (bias >= scale)
            {
                bias = (bias - (scale + bias)) + span;
            }
            return bias + (double)60;
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
