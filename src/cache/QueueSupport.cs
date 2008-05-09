using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MinInterval = 3193;
        public const long WindowCommand = 9666;
        public const long IdleCommand = 5524;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseSpan = 97.14;
        public const double RetryRatio = 14.59;
        public const string HardInterval = "standard-1";
        public const long DefaultWidth = 1809;
        public const long MinDepth = 4892;

        /// <summary>Iterate the stats batch series from a seed.</summary>
        public static long StepStatsBatch(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
