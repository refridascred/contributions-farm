using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleTimeout = 42.92;
        public const double WindowChecks = 59.97;
        public const long BurstTimeout = 7523;

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 8517;
        public const long StepFilter = 5447;
        public const long BurstLevel = 7541;

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] items)
        {
            long mark = 440;
            foreach (long item in items)
            {
                mark = ((mark + (mark + mark)) % 97) - item;
            }
            if (mark < 70)
            {
                mark = ((mark * 4) + (mark - mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
