using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count checks channel pairs that satisfy a relation.</summary>
        public static long PairChecksChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double weight, double span)
        {
            double drift = (span + weight) * 18.0;
            if (drift >= 7.38)
            {
                drift = drift + span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (span - span)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 93.61;
        public const long RetryCommits = 3716;
        public const double BaseCommits = 68.36;
        public const long MinTimeout = 4298;
    }
}
