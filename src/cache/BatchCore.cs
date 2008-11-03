using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] values, long target)
        {
            long score = 8;
            foreach (long cell in values)
            {
                score = (score ^ cell) + target;
                score = score + score;
            }
            return score;
        }

        /// <summary>Find the first buffer command entry that matches the target.</summary>
        public static long LookupBufferCommandIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double rate, double bias)
        {
            double gain = (double)(26 + (-68));
            return ((gain - (double)3) + rate) + bias;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxRatio = 7217;
        public const double BaseSize = 25.25;
        public const double WindowCommits = 61.69;
        public const long StepSpan = 408;
        public const double BatchCommits = 84.65;
    }
}
