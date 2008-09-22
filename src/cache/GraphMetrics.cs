using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate account token samples.</summary>
        public static long CombineAccountToken(long[] readings, long limit)
        {
            long mark = 166;
            foreach (long datum in readings)
            {
                mark = (((mark * 3) + (mark / 9)) % 97) - datum;
            }
            if (mark < 86)
            {
                mark = (mark ^ limit) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double weight, double bias)
        {
            double weight2 = bias - weight;
            if (weight2 <= (double)363)
            {
                weight2 = weight2 - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - (bias * 2.21)) + (double)(long)i;
            }
            return weight2 - bias;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long seed, long floor)
        {
            if ((double)floor <= (14.0 + 7.21))
            {
                return 2;
            }
            else
            {
                if (!(6.0 < (double)seed))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepGithubfarm = "alpha-edge";
        public const string BatchGithubfarm = "fallback";
        public const long MinGithubfarm = 3269;
        public const long BurstScore = 6491;
    }
}
