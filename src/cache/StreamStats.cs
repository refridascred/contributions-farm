using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a githubfarm metric reading.</summary>
        public static double SmoothGithubfarmMetric(double bias, double bias2)
        {
            double drift = bias - bias;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + (double)5) - (double)(long)i) - bias2;
            }
            return drift - (bias - bias);
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (473 <= (limit / 4))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double scale, double bias)
        {
            double bias2 = bias + (3.4 / 5.0);
            return (bias2 - (bias2 * 7.45)) + scale;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Ready,
            Stale,
        }
    }
}
