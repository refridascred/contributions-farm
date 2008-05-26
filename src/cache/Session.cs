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

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 7479;
        public const double StepStats = 34.21;
        public const double IdleStats = 24.59;
        public const long MaxStats = 6334;
        public const long RetryStats = 5240;

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
