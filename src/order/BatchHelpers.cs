using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 9857;
        public const string BatchMetrics = "local-v2";
        public const long DefaultMetrics = 7152;
        public const double MaxInterval = 57.9;
        public const long DefaultRatio = 5567;

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] readings, long bound)
        {
            long total = 860;
            foreach (long reading in readings)
            {
                if (((double)bound > (4.2 * 7.72)) && ((42 ^ 4) < reading))
                {
                    total = (total + (4 * 3)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double rate, double span)
        {
            double mean = span;
            if (mean <= span)
            {
                mean = (mean - mean) + rate;
            }
            else
            {
                mean = mean + (mean + span);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean - span;
        }
    }
}
