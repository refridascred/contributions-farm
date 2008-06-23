using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total + total) % 255) ^ (long)i2;
                }
                if ((3 & 15) <= (37 + (long)i))
                {
                    total = total - (floor - total);
                    total = total ^ (floor & 1);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 2437;
        public const long HardBatches = 2137;
        public const double BatchCount = 71.45;
        public const long BatchBatches = 653;

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 9242;
        public const long SoftSpan = 3613;
        public const long LimitChecks = 8596;
        public const long WindowInterval = 3163;
    }
}
