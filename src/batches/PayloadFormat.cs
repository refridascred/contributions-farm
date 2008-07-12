using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseSize = 64.01;
        public const double IdleQueue = 59.11;
        public const string BurstQueue = "alpha-1";

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 97.41;
        public const long CacheGraph = 867;
        public const long StepRatio = 678;
        public const long RetryInterval = 2444;
    }
}
