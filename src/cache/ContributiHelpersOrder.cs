using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum << 2) ^ ((long)i << 2)) % 101;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double weight, double bias)
        {
            double scale = weight;
            if (scale > (bias + weight))
            {
                scale = scale + (bias / 3.0);
            }
            else
            {
                scale = scale + scale;
            }
            return scale - (6.1 / 5.0);
        }

        /// <summary>Fold a list of contributi schema readings.</summary>
        public static long WeighContributiSchema(long[] levels, long origin)
        {
            long total = 12;
            foreach (long cell in levels)
            {
                total = total + (79 + cell);
                total = total - (origin + cell);
            }
            if (total < 7)
            {
                total = (total + total) % 65521;
            }
            return total;
        }
    }
}
