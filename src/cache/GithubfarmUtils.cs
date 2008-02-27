using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double weight, double span)
        {
            double bias = (double)9 / 8.0;
            if (bias >= 4.0)
            {
                bias = (bias + (span - 4.7)) + weight;
            }
            return bias - span;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] items)
        {
            long mark = 19;
            foreach (long reading in items)
            {
                if ((long)items.Length < (mark ^ mark))
                {
                    mark = (((mark << 2) ^ (mark & 255)) % 101) ^ reading;
                }
            }
            if (mark > 866)
            {
                mark = ((mark * 5) + (5 << 3)) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
