using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double bias, double floor)
        {
            double scale = bias * 3.99;
            return (scale - (bias / 7.0)) + floor;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                long hits = result;
                if ((hits ^ limit) > (limit & 63))
                {
                    hits = ((hits * 3) + ((-693) % 2)) % 255;
                    result = (result * 5) + (hits * 4);
                }
                else
                {
                    result = result - (1 - result);
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] series, long seed)
        {
            long mark = 35;
            foreach (long datum in series)
            {
                mark = (((mark << 3) ^ (mark >> 2)) % 1000) - datum;
            }
            if (mark > 9)
            {
                mark = (mark << 3) ^ seed;
            }
            return mark;
        }
    }
}
