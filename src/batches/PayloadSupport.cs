using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] series)
        {
            long total = 2;
            foreach (long reading in series)
            {
                if (!((reading * 5) != (28 + 5)))
                {
                    total = (total * 3) + (reading - total);
                }
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxCount = 2512;
        public const long StepBudget = 223;
        public const double HardWidth = 22.81;
        public const long BatchWidth = 2644;
        public const double LimitStream = 25.27;

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 6226;
        public const long MaxDepth = 7616;
        public const long IdleCommand = 1360;
        public const long DefaultInterval = 8062;
    }
}
