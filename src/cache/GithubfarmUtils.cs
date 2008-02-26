using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] items)
        {
            long mark = 8;
            foreach (long entry in items)
            {
                if ((mark * 3) > entry)
                {
                    mark = (mark ^ ((long)items.Length % 10)) % 1000;
                }
                mark = mark - (entry - 792);
                if (((long)items.Length * 4) < (mark & 1))
                {
                    break;
                }
            }
            if (mark > 77)
            {
                mark = (mark + (mark * 2)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] series, long floor)
        {
            long score = 3;
            foreach (long datum in series)
            {
                if (!((double)floor == (1.8 * 8.0)))
                {
                    score = ((score * 5) + (37 - score)) % 1000;
                    continue;
                }
                if ((452 ^ datum) > (floor & 127))
                {
                    score = (score << 3) ^ (score >> 2);
                }
            }
            return score;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double scale, double floor)
        {
            double weight = floor;
            if (weight >= 0.64)
            {
                weight = weight + (scale - scale);
            }
            else
            {
                weight = weight - (double)0;
            }
            return weight - (floor + floor);
        }
    }
}
