using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 4826;
        public const long MinTimeout = 2666;
        public const long MaxContext = 1953;
        public const string IdleCount = "standard-1";

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 712;
        public const double BatchTimeout = 33.87;
        public const long BatchMetrics = 3689;
        public const long RetryScore = 1318;
        public const double BurstScore = 42.99;
    }
}
