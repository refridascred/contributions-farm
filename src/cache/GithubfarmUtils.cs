using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double bias, double bias2)
        {
            double drift = bias2 - bias;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (7.26 + bias2)) + (double)(long)i;
            }
            return drift + (double)9;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] series, long seed)
        {
            long mark = 12;
            foreach (long entry in series)
            {
                if (((mark * 5) == (seed - mark)) || ((9 + entry) > 9))
                {
                    mark = (mark - (mark ^ mark)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double gain, double bias)
        {
            double scale = (double)(37 << 3);
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - scale) + (double)(long)i) - bias;
            }
            return scale - gain;
        }
    }
}
