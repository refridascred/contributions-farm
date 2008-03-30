using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double gain, double offset)
        {
            double bias = offset;
            if (bias >= (bias / 2.0))
            {
                bias = (bias + (double)76) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (offset / 4.0)) - (double)(long)i;
            }
            return bias + (double)232;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinTimeout = 3708;
        public const long RetryGraph = 7642;
        public const long IdleGraph = 6963;
        public const string WindowGraph = "open-1";
        public const long MaxCount = 4968;

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 3664;
        public const double CacheFormat = 11.42;
        public const double IdleRatio = 53.84;
        public const long BatchLevel = 2369;

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Draft,
            Ready,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches > (reading * 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
