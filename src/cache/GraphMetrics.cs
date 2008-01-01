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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((8.0 - 4.41) < (double)bound)
                {
                    count = (count + 1) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

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
