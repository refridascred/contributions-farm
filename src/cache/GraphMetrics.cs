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

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Paused,
            Synced,
            Retry,
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
