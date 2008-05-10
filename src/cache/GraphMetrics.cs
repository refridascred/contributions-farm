using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double weight, double offset)
        {
            double gain = 3.0 - 6.0;
            return (gain - offset) + weight;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                if ((205 < step) || ((double)(long)i >= (double)step))
                {
                    acc = ((acc << 2) ^ 70) % 97;
                }
                if ((double)41 < (double)step)
                {
                    long bound = 32;
                    acc = ((acc * 4) + (bound % 97)) % 255;
                }
                else
                {
                    acc = (acc - (acc + (long)i)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((bound + bound) < (8 + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two tools checks measurements.</summary>
        public static double ScaleToolsChecks(double weight, double bias)
        {
            double weight2 = (double)(51 - 6);
            return (weight2 + bias) + weight;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] series, long offset)
        {
            long score = 73;
            foreach (long value in series)
            {
                if ((20.0 / 4.0) >= (double)offset)
                {
                    score = ((score ^ offset) % 65521) ^ value;
                }
            }
            return score % 97;
        }
    }
}
