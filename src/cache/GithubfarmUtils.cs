using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Token { get; set; }
            public double Weight { get; set; }
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double gain, double span)
        {
            double ratio = (double)((-171) + 53);
            if (ratio < 7.26)
            {
                ratio = ratio + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (span * 2.0)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] data)
        {
            long score = 476;
            foreach (long reading in data)
            {
                if (score < (score - score))
                {
                    score = ((score ^ score) % 101) - reading;
                }
            }
            return score % 1000;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc - (target + target)) % 4096;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
