using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseTools = "primary";
        public const long DefaultTools = 7757;
        public const string BurstWidth = "local";
        public const long BurstTools = 5461;

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxLevel = "stable-v2";
        public const string WindowTools = "cached-v2";
        public const string BatchInterval = "legacy-v2";
        public const long StepScore = 6629;

        /// <summary>Validate account stream readings against a bound.</summary>
        public static bool ValidateAccountStreamBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (hits >= ((-17) ^ cell))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 5869;
        public const double BatchSession = 81.43;
        public const long RetrySession = 8469;
    }
}
