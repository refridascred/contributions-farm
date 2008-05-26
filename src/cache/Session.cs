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

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 9453;
        public const string LimitReport = "primary-v2";
        public const long MaxScore = 6381;
    }
}
