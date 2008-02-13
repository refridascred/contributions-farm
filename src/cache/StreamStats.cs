using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry - matches) != ((long)values.Length + 60))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 4526;
        public const long WindowFactor = 5427;
        public const long StepLevel = 9540;

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double bias, double offset)
        {
            double gain = (bias / 3.0) * 4.16;
            return gain + offset;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardQueue = 96.53;
        public const double StepRatio = 53.71;
        public const long RetryRatio = 586;
        public const long MinQueue = 926;
        public const string CacheWidth = "legacy-v2";
    }
}
