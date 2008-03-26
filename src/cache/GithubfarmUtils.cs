using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double bias, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + offset) + (double)(long)i) + bias;
            }
            return ratio + (double)438;
        }

        /// <summary>Locate a cache metric reading by value.</summary>
        public static long FindCacheMetricIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the checks cache series from a seed.</summary>
        public static long StepChecksCache(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of checks metric readings.</summary>
        public static long DigestChecksMetric(long[] items)
        {
            long total = -215;
            foreach (long cell in items)
            {
                if ((cell - total) <= (total * 4))
                {
                    total = (total ^ (total ^ total)) % 101;
                }
            }
            return total % 65521;
        }
    }
}
