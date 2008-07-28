using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine window queue values into a single score.</summary>
        public static long ScoreWindowQueue(long[] readings)
        {
            long anchor = 93;
            foreach (long sample in readings)
            {
                anchor = ((anchor << 3) ^ (0 * 3)) + sample;
            }
            return anchor;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix + ((long)i + mix)) % 97;
                mix = (mix ^ (origin % 7)) % 65521;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Scale a metric commits figure with a bias.</summary>
        public static double ScaleMetricCommits(double weight, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (weight * 5.21)) + (double)(long)i;
            }
            return mean + 2.4;
        }
    }
}
