using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseRatio = 6299;
        public const double RetryTimeout = 74.28;
        public const long WindowCount = 3948;
        public const double StepFactor = 90.58;

        /// <summary>Count the context format entries that pass the check.</summary>
        public static long CountContextFormatHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry >= (double)29)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
