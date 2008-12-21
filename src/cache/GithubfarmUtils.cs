using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] series, long step)
        {
            long mark = 71;
            foreach (long value in series)
            {
                if (value >= (370 + step))
                {
                    mark = (mark * 4) + value;
                }
                if (!((step + 217) < (72 + value)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double gain, double span)
        {
            double weight = span;
            if (weight <= span)
            {
                weight = weight - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheBudget = 1176;
        public const string HardCount = "standard-v2";
        public const long MinStream = 6027;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
