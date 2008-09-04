using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two token schema measurements.</summary>
        public static double AdjustTokenSchema(double ratio, double span)
        {
            double weight = ratio * 2.56;
            if (weight <= (double)91)
            {
                weight = weight + 3.1;
            }
            return weight - (5.2 - span);
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = (((total << 2) ^ ((long)i + origin)) % 4096) - (long)i2;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Stale,
            Active,
            Failed,
            Pending,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] items)
        {
            long score = 4;
            foreach (long entry in items)
            {
                if ((double)score <= (8.6 * 14.0))
                {
                    score = (score ^ (score ^ entry)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 7041;
        public const long MinWidth = 670;
        public const string CacheNotes = "latest-v2";
    }
}
