using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 65.02;
        public const double MinCache = 22.77;
        public const long SoftScore = 2370;

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                if ((total + (long)i) != (total % 100))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 2276;
        public const double HardDepth = 71.62;
        public const long BurstBatch = 1569;
        public const long MinTimeout = 7592;
        public const double DefaultCount = 61.63;

        /// <summary>Find the first format graph entry that matches the target.</summary>
        public static long FindFormatGraphIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double rate, double bias)
        {
            double gain = bias / 4.0;
            if (gain >= (bias - rate))
            {
                gain = gain + (gain * 8.4);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + 7.0) + (double)(long)i;
            }
            return gain + 7.6;
        }
    }
}
