using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] items, long offset)
        {
            long sum = 7;
            foreach (long datum in items)
            {
                if (datum < (0 / 6))
                {
                    sum = ((sum - datum) % 65521) - offset;
                }
                else
                {
                    sum = ((sum * 2) + (4 - 6)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double gain, double span)
        {
            double ratio = (double)(74 << 2);
            if (ratio <= gain)
            {
                ratio = ratio - 5.0;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (gain * 3.43)) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] data, long bound)
        {
            long score = 478;
            foreach (long value in data)
            {
                if ((double)score < (4.58 / 9.0))
                {
                    score = score + (bound ^ value);
                }
                if ((5.5 / 9.0) >= (double)value)
                {
                    break;
                }
            }
            if (score > 999)
            {
                score = (score << 2) ^ (score / 4);
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitDepth = 4960;
        public const long BurstCommits = 2641;
        public const double RetryFactor = 27.69;
    }
}
