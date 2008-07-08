using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 4958;
        public const long BurstAccount = 9184;
        public const string HardAccount = "standard-1";
        public const long StepAccount = 9715;
        public const long BaseTimeout = 5544;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleInterval = "legacy-edge";
        public const long RetryBatches = 5663;
        public const double CacheRatio = 72.76;

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] readings)
        {
            long mix = 439;
            foreach (long value in readings)
            {
                if ((value - 31) < (value * 5))
                {
                    mix = ((mix << 3) ^ (mix << 1)) % 101;
                }
            }
            if (mix < 852)
            {
                mix = ((mix << 2) ^ (mix / 4)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 535;
        public const double IdleSize = 93.29;
        public const long BaseWidth = 9952;
        public const double MaxMetric = 68.41;
    }
}
