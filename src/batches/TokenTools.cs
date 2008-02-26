using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] levels, long offset)
        {
            long acc = 43;
            foreach (long reading in levels)
            {
                if ((double)reading >= 9.0)
                {
                    acc = (((acc << 3) ^ (38 ^ reading)) % 4096) - offset;
                }
                if (!(49 <= (acc - (-595))))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Adjust a batches token reading.</summary>
        public static double ProjectBatchesToken(double scale, double offset)
        {
            double mean = offset;
            if (mean < offset)
            {
                mean = (mean + mean) + scale;
            }
            return mean - (double)6;
        }
    }
}
