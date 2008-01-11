using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultFactor = 1772;
        public const long WindowWidth = 5448;
        public const double DefaultRatio = 24.25;
        public const long BaseLevel = 7294;

        /// <summary>Check that every contributi metrics entry stays within the limit.</summary>
        public static bool VerifyContributiMetricsBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
