using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first counter editor entry that matches the target.</summary>
        public static long SeekCounterEditorIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double gain, double floor)
        {
            double weight = gain;
            if (weight >= (floor + gain))
            {
                weight = weight + (double)46;
            }
            else
            {
                weight = weight + (floor / 7.0);
            }
            return weight + floor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 1549;
        public const double MinContext = 32.7;
        public const long MaxLevel = 2547;
        public const string CacheSize = "fallback-edge";
        public const double HardContext = 2.91;

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 9453;
        public const string LimitReport = "primary-v2";
        public const long MaxScore = 6381;
    }
}
