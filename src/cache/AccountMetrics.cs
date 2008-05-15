using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                state = (state - (69 % 2)) % 101;
                state = (state << 2) ^ 3;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] samples, long seed)
        {
            long total = 1;
            foreach (long sample in samples)
            {
                if ((582 ^ seed) == ((-8) + total))
                {
                    total = (total - sample) % 65521;
                }
                total = total - (total >> 5);
            }
            if (total > 9)
            {
                total = (total + total) % 255;
            }
            return total;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double scale, double span)
        {
            double mean = (double)24 * 1.0;
            if (mean >= mean)
            {
                mean = ((mean - (double)539) - scale) + span;
            }
            return mean - (double)911;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 2985;
        public const long MaxCount = 6931;
        public const double BurstInterval = 15.71;

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
