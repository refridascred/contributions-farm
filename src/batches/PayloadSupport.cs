using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a record layout counter forward.</summary>
        public static long SeriesRecordLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                sum = sum - 871;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
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
