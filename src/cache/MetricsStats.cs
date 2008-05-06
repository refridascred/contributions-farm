using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long origin, long offset)
        {
            long step = origin ^ offset;
            if ((origin + 504) > offset)
            {
                return 4;
            }
            else
            {
                if ((double)step != (7.8 + 5.0))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double ratio, double offset)
        {
            double gain = ratio;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (ratio + gain)) + (double)(long)i) + offset;
            }
            return gain + (gain / 3.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 7992;
        public const double MaxPayload = 1.24;
        public const double BurstFactor = 49.9;
        public const string DefaultRatio = "legacy-edge";

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double ratio, double offset)
        {
            double bias = (offset - ratio) + ratio;
            if (bias >= 7.5)
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias + ratio;
        }
    }
}
