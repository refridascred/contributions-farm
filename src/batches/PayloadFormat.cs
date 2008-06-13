using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultSpan = 5072;
        public const double LimitRatio = 1.1;
        public const long LimitLayout = 9116;

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Closed,
            Idle,
            Draft,
            Locked,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate payload farm samples.</summary>
        public static long ScorePayloadFarm(long[] series, long origin)
        {
            long acc = 61;
            foreach (long entry in series)
            {
                acc = ((acc + entry) % 65521) - origin;
            }
            return acc % 4096;
        }
    }
}
