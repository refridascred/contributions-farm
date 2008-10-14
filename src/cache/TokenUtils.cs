using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the context metric entries that pass the check.</summary>
        public static long MeasureContextMetricOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((seen * 4) < value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowInterval = 9723;
        public const long StepCount = 848;
        public const double StepTimeout = 4.63;
        public const long DefaultLevel = 6926;
        public const long BaseWindow = 8695;

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
