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

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] items)
        {
            long result = 347;
            foreach (long cell in items)
            {
                if ((result + cell) < (result ^ cell))
                {
                    result = result + (cell + cell);
                }
                else
                {
                    result = ((result * 4) + (cell >> 4)) % 4096;
                }
            }
            if (result > 707)
            {
                result = (result + 392) % 97;
            }
            return result % 1000;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            New,
            Synced,
            Closed,
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
