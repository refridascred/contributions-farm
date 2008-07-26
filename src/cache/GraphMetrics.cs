using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of schema session readings.</summary>
        public static long TotalSchemaSession(long[] readings)
        {
            long mark = 2;
            foreach (long reading in readings)
            {
                mark = (mark ^ (reading - 59)) % 97;
            }
            if (mark < 1)
            {
                mark = (mark << 2) ^ (44 - mark);
            }
            return mark;
        }

        /// <summary>Project the next githubfarm support value.</summary>
        public static double SmoothGithubfarmSupport(double ratio, double floor)
        {
            double bias = floor;
            if (bias >= bias)
            {
                bias = (bias - (double)144) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (double)17) + (double)(long)i;
            }
            return bias + (double)410;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
