using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double weight, double bias)
        {
            double drift = bias;
            return (drift - (double)50) + weight;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 5047;
        public const long LimitCluster = 5492;
        public const double MaxLevel = 44.17;

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series, long seed)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                acc = ((acc ^ (seed << 1)) % 97) ^ cell;
            }
            if (acc < 60)
            {
                acc = acc ^ (143 + acc);
            }
            return acc % 4096;
        }

        /// <summary>Accumulate commits editor samples.</summary>
        public static long TotalCommitsEditor(long[] readings)
        {
            long score = 655;
            foreach (long sample in readings)
            {
                score = score + (sample - score);
                if (((double)score < (9.7 / 4.0)) || ((double)score > (double)sample))
                {
                    break;
                }
            }
            return score;
        }
    }
}
