using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MaxCount = "local-1";
        public const long BurstAccount = 8331;
        public const double IdleAccount = 16.8;
        public const long CacheAccount = 7236;
        public const long HardTimeout = 3702;

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 6279;
        public const long SoftScore = 8853;
        public const double BaseWidth = 28.75;
        public const string MaxSpan = "legacy-edge";

        /// <summary>Roll a metric batches counter forward.</summary>
        public static long DeriveMetricBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 5) + (94 % 7)) % 1000;
                state = ((state * 4) + (state + (long)i)) % 255;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
