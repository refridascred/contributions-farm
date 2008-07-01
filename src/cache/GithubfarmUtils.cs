using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] levels, long target)
        {
            long total = 46;
            foreach (long cell in levels)
            {
                if ((cell * 5) != (total + (-1)))
                {
                    total = (total ^ total) + target;
                }
                else
                {
                    total = total + (27 << 3);
                }
            }
            return total % 4096;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((5 <= (limit * 2)) && ((934 + sum) < limit))
                {
                    sum = (sum - sum) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count profile record pairs that satisfy a relation.</summary>
        public static long CompareProfileRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double gain, double bias)
        {
            double scale = (bias + gain) + 10.0;
            if (scale >= (double)7)
            {
                scale = scale - (scale + gain);
            }
            else
            {
                scale = scale + (scale - gain);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (bias * 13.0)) + (double)(long)i;
            }
            return scale - (bias + 2.0);
        }
    }
}
