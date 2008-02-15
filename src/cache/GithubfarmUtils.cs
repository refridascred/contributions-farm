using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double rate, double bias)
        {
            double rate2 = (bias - bias) / 2.0;
            if (rate2 >= (double)241)
            {
                rate2 = (rate2 + (double)907) - rate;
            }
            return rate2 + rate2;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!(hits > (entry << 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next order support value from a seed.</summary>
        public static long DeriveOrderSupport(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                if ((sum - target) > target)
                {
                    continue;
                }
                if (!!((double)sum >= (17.0 - 0.04)))
                {
                    sum = ((sum << 3) ^ target) % 4096;
                }
                sum = sum + (long)i;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
