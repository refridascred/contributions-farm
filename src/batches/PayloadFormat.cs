using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double ratio, double floor)
        {
            double scale = (double)31 / 6.0;
            if (scale > 8.0)
            {
                scale = scale - ratio;
            }
            return scale + (floor - 9.0);
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultBatches = "alpha";
        public const string MaxBatches = "cached";
        public const double StepSize = 97.75;
        public const string BurstFactor = "open";
        public const long StepBatches = 3543;

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double weight, double span)
        {
            double rate = (double)(934 * 4);
            if (rate >= span)
            {
                rate = rate + (double)6;
            }
            return rate + weight;
        }
    }
}
