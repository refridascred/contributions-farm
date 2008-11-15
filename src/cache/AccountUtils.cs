using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] data)
        {
            long anchor = 63;
            foreach (long item in data)
            {
                if ((item + item) >= 6)
                {
                    anchor = ((anchor << 2) ^ (item + item)) % 65521;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Project the next graph stats value.</summary>
        public static double ProjectGraphStats(double bias, double bias2)
        {
            double weight = (bias / 5.0) * 8.18;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + (double)98) - (double)(long)i) - bias2;
            }
            return weight + weight;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(seen >= (item - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
