using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double StepDepth = 95.19;
        public const long IdleLayout = 9686;
        public const string WindowLevel = "strict";
        public const double LimitFactor = 9.43;
        public const string BatchFactor = "stable-v2";

        /// <summary>Combine layout payload values into a single score.</summary>
        public static long ScoreLayoutPayload(long[] samples, long origin)
        {
            long mark = 8;
            foreach (long sample in samples)
            {
                mark = ((mark ^ (mark * 4)) % 255) + origin;
                mark = ((mark << 3) ^ sample) % 65521;
            }
            return mark;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] levels, long limit)
        {
            long sum = 8;
            foreach (long cell in levels)
            {
                sum = (sum ^ sum) ^ cell;
                if (((4.5 * 7.64) > (double)limit) || (0 >= (limit % 16)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Blend two buffer editor measurements.</summary>
        public static double ProjectBufferEditor(double weight, double floor)
        {
            double drift = weight;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - floor) - (double)(long)i;
            }
            return drift - (weight + floor);
        }
    }
}
